using Common.Entities;
using DomainEntities;
using Common.Utility;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Dynamic;
using System.Text.Encodings.Web;
using System;
using GolfApi.Model.GameManagement.Request;
using GolfApi.Model.GameManagement.Response;
using Microsoft.EntityFrameworkCore;
using Quartz;
using System.Threading.Tasks;

namespace GolfApi.Services
{
    public class GameMatchBackendCalcService:IJob
    {
        private readonly GolfDbContext _DbContext;
        private readonly ILogger<GameManagementService> _logger;
    
        public GameMatchBackendCalcService(GolfDbContext DbContext)
        {
            _DbContext = DbContext;
            _logger = LoggerFactory.Create(builder => builder.AddConsole())
                       .CreateLogger<GameManagementService>();
        }

       public Task Execute(IJobExecutionContext context)
        {
          
            _logger.LogInformation("in ExecuteAsync");
 
            var scoreCardSubmissionList = _DbContext.ScoreCardSubmissions.ToList();
            _logger.LogInformation("total scorecard number: " + scoreCardSubmissionList.Count());
            foreach(var scorecardSub in scoreCardSubmissionList)
            {
                //fetch scorecard
                var gameScorecard = _DbContext.GameMatchScoreCard.Where(e=>e.game_match_score_card_id == scorecardSub.Game_match_score_card_id).FirstOrDefault()?? throw new DataNotFoundException("game score card not found");
                _logger.LogInformation("processing scorecard: " + scorecardSub.Game_match_score_card_id);
                //step1: upgrade level if score > 85%
                if(gameScorecard.score >= 0.85)
                {
                    //fetch users
                    var golfer = _DbContext.Users.Where(e=>e.UserSystemId == gameScorecard.golfer_id).FirstOrDefault()?? throw new DataNotFoundException("golfer not found");
                    if(golfer.Level_id < 5)
                    {
                        golfer.Level_id += 1;
                        _logger.LogInformation("golfer :" + golfer.FirstName + "Level upgraded to next level");
                        _DbContext.Users.Update(golfer);
                    }
                }
                //perfect game quit
                if(scorecardSub.Game_Type_id == 1)
                {
                    _logger.LogInformation("Golf Pefect game complete ");
                    _DbContext.ScoreCardSubmissions.Remove(scorecardSub);
                    break;
                }
                //step2: mark this match's winner
                var gameScoreCard_Opponent = _DbContext.GameMatchScoreCard.Where(e=>e.game_milestone_match_id==gameScorecard.game_milestone_match_id && e.golfer_id != gameScorecard.golfer_id).FirstOrDefault() ;
                if(gameScoreCard_Opponent == null || gameScoreCard_Opponent.status != "complete")
                {
                    //remove this submission
                    _logger.LogInformation("Opponent game not complete,quit here");
                    _DbContext.ScoreCardSubmissions.Remove(scorecardSub);
                    break;
                }

              
                //fetch game match
                var gameMilestoneMatch = _DbContext.GameMilestoneMatch.Where(e=>e.game_milestone_match_id == gameScorecard.game_milestone_match_id).FirstOrDefault()?? throw new DataNotFoundException("game milestone match not found");
                //mark winner for this match
                if(gameScorecard.score >= gameScoreCard_Opponent.score)
                    gameMilestoneMatch.winner = gameScorecard.golfer_id;
                else
                    gameMilestoneMatch.winner = gameScoreCard_Opponent.golfer_id;
                gameMilestoneMatch.status = "complete";
                gameMilestoneMatch.golfer_1_score = gameScorecard.score;
                gameMilestoneMatch.golfer_2_score = gameScoreCard_Opponent.score;
                gameMilestoneMatch.last_upt_time = DateTime.Now;
                _DbContext.GameMilestoneMatch.Update(gameMilestoneMatch);

               
                //step3: mark this milestone complete 
                //step3.1: check if all matches are complete under this milestone, if not, quit.
                var Allmatches4ThisMilestoneList = _DbContext.GameMilestoneMatch.Where(e=>e.game_milestone_id==gameMilestoneMatch.game_milestone_id).ToList()?? throw new DataNotFoundException("game milestone matches not found");
                
                foreach(var milestoneMatch in Allmatches4ThisMilestoneList )
                {
                    if(milestoneMatch.status != "complete") 
                    {
                        //remove this submission
                        _logger.LogInformation("not all matched under current milestone complete,quit here");
                        _DbContext.ScoreCardSubmissions.Remove(scorecardSub);
                        break;
                    }
                }
                //step3.2 mark this milestone complete
                var milestone = _DbContext.GameMilestone.Where(e=>e.game_milestone_id == gameMilestoneMatch.game_milestone_id).FirstOrDefault()?? throw new DataNotFoundException("game milestone not found");

                milestone.status = "complete";
                milestone.last_upt_time = DateTime.Now;
                _DbContext.GameMilestone.Update(milestone);

                //Step4: initialize next milestone game
                if(milestone.final_indc == 1)
                {
                    //remove this submission
                    _logger.LogInformation("this milestone is final here,quit!");
                    _DbContext.ScoreCardSubmissions.Remove(scorecardSub);
                    break;
                }
                var nextMilestoneSequence = milestone.sequence + 1;
                //fetch the milestone template 
                var milestoneT = _DbContext.GameMilestoneT.Where(e=>e.game_type_id == scorecardSub.Game_Type_id 
                                                                    && e.sequence == nextMilestoneSequence && e.handlesize == milestone.handlesize ).FirstOrDefault() ?? throw new DataNotFoundException("game milestone template not found");
                //Step4.1 create new milestone

                var milestoneNext = new GameMilestone()
                {
                    game_milestoneT_id = milestoneT.game_milestoneT_id,
                    game_id = scorecardSub.Game_id,
                    handlesize = milestone.handlesize,
                    sequence = nextMilestoneSequence,
                    milestone_code = milestoneT.milestone_code,
                    final_indc = milestoneT.final_indc,
                    status = "approved",
                    create_time = DateTime.Now,
                    last_upt_time = DateTime.Now,

                };

                _DbContext.GameMilestone.Add(milestoneNext);
                
                //Step4.2 populate GameMilestoneMatch
                //fetch GameMilestoneMatchT
                var milestoneMatchTList = _DbContext.GameMilestoneMatchT.Where(e=>e.game_milestoneT_id == milestoneT.game_milestoneT_id).ToList() ?? throw new DataNotFoundException("Game Milestone Match Template not found");
                _logger.LogInformation("Creating next milestone matches, continue");
                foreach(var milestoneMatchT in milestoneMatchTList)
                {
                    //locate golfer_1
                    var match_golfer_1 = 0L;
                    var prevMatch1 = Allmatches4ThisMilestoneList.Find(e=>e.match_code==milestoneMatchT.golfer_1);
                    if(milestoneMatchT.golfer_1 == "winner") match_golfer_1=prevMatch1.winner;
                    else match_golfer_1 = (prevMatch1.golfer_1==prevMatch1.winner)? prevMatch1.golfer_2:prevMatch1.golfer_1;

                    //locate golfer_2
                    var match_golfer_2 = 0L;
                    var prevMatch2 = Allmatches4ThisMilestoneList.Find(e=>e.match_code==milestoneMatchT.golfer_2_rule);
                    if(milestoneMatchT.golfer_2 == "winner") match_golfer_2=prevMatch2.winner;
                    else match_golfer_2 = (prevMatch2.golfer_1==prevMatch2.winner)? prevMatch2.golfer_2:prevMatch2.golfer_1;

                    var gameMilestoneMatchx = new GameMilestoneMatch()
                    {
                        game_id = scorecardSub.Game_id,
                        game_milestone_id = milestoneNext.game_milestone_id,
                        game_milestone_matchT_id = milestoneMatchT.game_milestone_matchT_id,
                        golfer_1 = match_golfer_1,
                        golfer_2 = match_golfer_2,
                        match_code = milestoneMatchT.match_code,
                        sequence = milestoneNext.sequence,
                        milestone_code = milestoneNext.milestone_code,
                        final_indc = milestoneNext.final_indc,
                        winner=0,
                        status= "active",
                        create_time = DateTime.Now,
                        last_upt_time = DateTime.Now,
                    };

                    _DbContext.GameMilestoneMatch.Add(gameMilestoneMatchx);
                
                }



                //step5: commit the changes

                _logger.LogInformation("all steps are complete for submission :" + scorecardSub.Game_match_score_card_id);
                //remove this submission
                _DbContext.ScoreCardSubmissions.Remove(scorecardSub);
              
                

            }
            _DbContext.SaveChanges();
            return Task.FromResult(true);
        
        }

    }

}