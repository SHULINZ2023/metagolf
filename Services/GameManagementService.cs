
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

namespace GolfApi.Services
{
    public class GameManagementService
    {
        private  GolfDbContext _DbContext;
        private readonly ILogger<GameManagementService> _logger;
    
        public GameManagementService(GolfDbContext DbContext)
        {
            _DbContext = DbContext;
            _logger = LoggerFactory.Create(builder => builder.AddConsole())
                       .CreateLogger<GameManagementService>();
        }

        public List<Model.GameManagement.Response.GameListResponse>getGameList4Email(Model.GameManagement.Request.GameListRequest request)
        {
            var sqlGameListDao = new SqlGameDao(_DbContext);
            return sqlGameListDao.GetGamesByGameTypeAndEmail(request.game_type_id,request.Email);
        }
      
        public GameNewResponse GetNewGameParam()
        {
            var gameNewResponse = new GameNewResponse();

            var areas = _DbContext.Area.Where(e=>e.status=="Approved").ToList();
            gameNewResponse.areas = areas;

            var golfCourses = _DbContext.GolfCourses.Where(e=>e.status=="Approved").ToList();

            gameNewResponse.golfCourses = golfCourses;

            var users = _DbContext.Users.ToList();

            gameNewResponse.golfers = users;
            
            return gameNewResponse;
        }

        public string GameSubmitScoreCard(GameInitScoreCardResponse gameScoreCard)
        {
            _logger.LogInformation(gameScoreCard.ToString());
            
            _DbContext.GameMatchScoreCard.Update(gameScoreCard.GameScoreCard);
            
            
            if(gameScoreCard != null)
            {
                foreach(var stroke in gameScoreCard.GameStrokes)
                {
                    _DbContext.GameMatchStroke.Add(stroke);
                }
            }
            //check if match is done, mark the winner
            //create an entry in submission table
            var newScoreCardSubmission = new ScoreCardSubmission()
            {
                 Game_match_score_card_id = gameScoreCard.GameScoreCard.game_match_score_card_id,
                 Game_Type_id = gameScoreCard.Game.game_type_id,
                 Game_id = gameScoreCard.Game.game_id,
                 Status = "approved",
                
            };

            _DbContext.ScoreCardSubmissions.Add(newScoreCardSubmission)
            ;

            
            _DbContext.SaveChanges();
            return "ok";
        }
        public GameInitScoreCardResponse InitGameScoreCard(long game_id,string golfer )
        { 
            
            // fetch all golf course holes and holes tees
            _logger.LogInformation("Here in GameManagementService.InitGameScoreCard");
            var golferGameScoreCard = new GameInitScoreCardResponse();
            var game = _DbContext.Games.Where(e=>e.game_id==game_id).FirstOrDefault();
            golferGameScoreCard.Game = game ?? throw new DataNotFoundException("not game record found");
            var golfCourse = _DbContext.GolfCourses.Where(e=>e.golf_course_id == game.golf_course_id).FirstOrDefault();
            
            golferGameScoreCard.GolfCourse = golfCourse ?? throw new DataNotFoundException("golf Course not found");
            var courseholes = _DbContext.CourseHoles.Where(e=>e.golf_course_id==game.golf_course_id);
            if(!courseholes.Any()) throw new DataNotFoundException("Course Holdes not found");
            golferGameScoreCard.CourseHoles = courseholes.ToList();

            _logger.LogInformation("GameHoles");
            var CourseHoleTees = _DbContext.CourseTees.Where(e=>e.golf_course_id ==game.golf_course_id);
            
            if(CourseHoleTees.Any())
                golferGameScoreCard.CourseHoleTees = CourseHoleTees.ToList();
            else
            {
                CourseHoleTees = _DbContext.CourseTees.Where(e=>e.golf_course_id == 0);
                golferGameScoreCard.CourseHoleTees = CourseHoleTees.ToList();
            }
            
                

           _logger.LogInformation("GameHoleRoadmaps");


           var gameHoleRoadmaps=_DbContext.GameHoleRoadmap.Where(e=>e.game_type_id==0).OrderBy(e=>e.sequence);
           if(!gameHoleRoadmaps.Any()) throw new DataNotFoundException("RoadMap not found");
            golferGameScoreCard.GameHoleRoadmaps = gameHoleRoadmaps.ToList();   
            
            var golferUser = _DbContext.Users.Where(e=>e.Email==golfer).FirstOrDefault() ??  throw new DataNotFoundException("golfer record not found");
            golferGameScoreCard.GameUser = golferUser;
            golferGameScoreCard.userLevel = _DbContext.Level.Where(e=>e.status=="Approved" && e.level_id==golferUser.Level_id).FirstOrDefault() ?? throw new DataNotFoundException("Level record not found");

            var gameMatch = _DbContext.GameMilestoneMatch.Where( e=>(e.status == "active" || e.status == "approved" ) && e.game_id==game_id && 
             (e.golfer_1 == golferUser.UserSystemId || e.golfer_2 == golferUser.UserSystemId)).FirstOrDefault();
            


            golferGameScoreCard.GameMatch = gameMatch ?? throw new DataNotFoundException("game match not found");
            if(gameMatch.status == "approved")
            {
                gameMatch.status = "active";
                _DbContext.Update(gameMatch);
            }
            var oppoUserid = (gameMatch.golfer_1 == golferUser.UserSystemId)?gameMatch.golfer_2:gameMatch.golfer_1;
            if(oppoUserid != 0) golferGameScoreCard.Opponent = _DbContext.Users.Where(e=>e.UserSystemId==oppoUserid).FirstOrDefault() ?? throw new DataNotFoundException("Opponent user not found");     

            var gameMileStone = _DbContext.GameMilestone.Where(e=>e.game_milestone_id == gameMatch.game_milestone_id).FirstOrDefault();
            golferGameScoreCard.Milestone = gameMileStone ?? throw new DataNotFoundException("mile stone not found");

            //populate game score card
            var gameScoreCard = _DbContext.GameMatchScoreCard.Where(
                e=>e.game_milestone_match_id==golferGameScoreCard.GameMatch.game_milestone_match_id && e.golfer_id==golferUser.UserSystemId).FirstOrDefault();
            if(gameScoreCard == null)
            {
                gameScoreCard = new Common.Entities.GameMatchScoreCard()
                {
                game_milestone_match_id=gameMatch.game_milestone_match_id,
                golfer_id = golferUser.UserSystemId,
                status = "Active"
                };
                _DbContext.GameMatchScoreCard.Add(gameScoreCard);
            }
            golferGameScoreCard.GameScoreCard = gameScoreCard;

            golferGameScoreCard.GameStrokes = _DbContext.GameMatchStroke.Where(
                e=>e.game_match_score_card_id==golferGameScoreCard.GameScoreCard.game_match_score_card_id).ToList();
            _DbContext.SaveChanges();
            return golferGameScoreCard;
        }

        public int CreateNewGame(NewGameRequest request,string creator)
        {
            var sqlGameListDao = new SqlGameDao(_DbContext);

            Common.Entities.Games newGame = new Common.Entities.Games();

            newGame.status="Approved";
            newGame.last_upt_time = DateTime.Now;
            newGame.game_date = request.game_date;
            newGame.golf_course_id = request.golfcourse_id;
            newGame.game_name = request.golfcourse_name;
            newGame.create_time = DateTime.Now;
            newGame.game_type_id = request.game_type_id;
            newGame.start_half_id = request.half_course_id;
            newGame.creator=creator;
            if(newGame.game_type_id == 1 || newGame.game_type_id == 2)
                newGame.golfhandle0=creator;
            else    
                newGame.golfhandle0=request.golfhandle0;
            newGame.golfhandle1=request.golfhandle1;
            newGame.golfhandle2=request.golfhandle2;
            newGame.golfhandle3=request.golfhandle3;
            newGame.golfhandle4=request.golfhandle4;
            newGame.golfhandle5=request.golfhandle5;
            newGame.golfhandle6=request.golfhandle6;
            newGame.golfhandle7=request.golfhandle7;

            int count = sqlGameListDao.CreateNewGame(newGame);
            //populate game_milestone
            //1: retrieve the milestone template
            // determine handlesize
            var handlesize = 0;
            switch(newGame.game_type_id)
            {
                case 1:
                  handlesize =1;
                  break;
                case 2:
                    handlesize =2;
                    break;
                case 3:
                    if(newGame.golfhandle0 != "not defined") handlesize += 1;
                    if(newGame.golfhandle1 != "not defined") handlesize += 1;
                    if(newGame.golfhandle2 != "not defined") handlesize += 1;
                    if(newGame.golfhandle3 != "not defined") handlesize += 1;
                    break;
                case 4:
                    if(newGame.golfhandle0 != "not defined") handlesize += 1;
                    if(newGame.golfhandle1 != "not defined") handlesize += 1;
                    if(newGame.golfhandle2 != "not defined") handlesize += 1;
                    if(newGame.golfhandle3 != "not defined") handlesize += 1;
                    break;        

            }
              
            var milestoneT = _DbContext.GameMilestoneT.FirstOrDefault(e=>e.game_type_id==newGame.game_type_id && e.sequence==0 && e.handlesize==handlesize);
            if(milestoneT == null) throw new DataNotFoundException("MileStoneT is not found");
            var milestone0 = new Common.Entities.GameMilestone();
            milestone0.game_milestoneT_id = milestoneT.game_milestoneT_id;
            milestone0.game_id = newGame.game_id;
            milestone0.handlesize = handlesize;
            milestone0.sequence = 0;
            milestone0.milestone_code = milestoneT.milestone_code;
            milestone0.final_indc = milestoneT.final_indc;
            milestone0.status = "Approved";
            milestone0.create_time = DateTime.Now;
            milestone0.last_upt_time= DateTime.Now;

            _DbContext.GameMilestone.Add(milestone0);
            //populate GameMilestoneMatch
            //_DbContext.SaveChanges();
            //1: retrieve template GameMilestoneMatchT
            var gameMilestoneMatchT = _DbContext.GameMilestoneMatchT.Where(e=>e.game_milestoneT_id==milestone0.game_milestoneT_id).ToList();
            foreach (var matchT in gameMilestoneMatchT)
            {
                //create milestonematch instance
                
                //determine match golfer 1 and golfer 2
                var golfer1_email = "not defined";
                var golfer2_email = "not defined";
                if(matchT.golfer_1 == "handle0" ) golfer1_email = newGame.golfhandle0 ;
                if(matchT.golfer_1 == "handle1" ) golfer1_email = newGame.golfhandle1 ;
                if(matchT.golfer_1 == "handle2" ) golfer1_email = newGame.golfhandle2 ;
                if(matchT.golfer_1 == "handle3" ) golfer1_email = newGame.golfhandle3 ;
                if(matchT.golfer_1 == "handle4" ) golfer1_email = newGame.golfhandle4 ;
                if(matchT.golfer_1 == "handle5" ) golfer1_email = newGame.golfhandle5 ;
                if(matchT.golfer_1 == "handle6" ) golfer1_email = newGame.golfhandle6 ;
                if(matchT.golfer_1 == "handle7" ) golfer1_email = newGame.golfhandle7 ;
                
                if(matchT.golfer_2 == "handle0" ) golfer2_email = newGame.golfhandle0 ;
                if(matchT.golfer_2 == "handle1" ) golfer2_email = newGame.golfhandle1 ;
                if(matchT.golfer_2 == "handle2" ) golfer2_email = newGame.golfhandle2 ;
                if(matchT.golfer_2 == "handle3" ) golfer2_email = newGame.golfhandle3 ;
                if(matchT.golfer_2 == "handle4" ) golfer2_email = newGame.golfhandle4 ;
                if(matchT.golfer_2 == "handle5" ) golfer2_email = newGame.golfhandle5 ;
                if(matchT.golfer_2 == "handle6" ) golfer2_email = newGame.golfhandle6 ;
                if(matchT.golfer_2 == "handle7" ) golfer2_email = newGame.golfhandle7 ;
               
                long golfer_id_1 = 0, golfer_id_2 =0;
                _logger.LogInformation(golfer1_email);
                _logger.LogInformation(golfer2_email);

                if(!string.Equals(golfer1_email, "not defined"))golfer_id_1 = _DbContext.Users.FirstOrDefault(e=>e.Email==golfer1_email).UserSystemId;
                if(!string.Equals(golfer2_email, "not defined"))golfer_id_2 = _DbContext.Users.FirstOrDefault(e=>e.Email==golfer2_email).UserSystemId;
                var gameMatch = new Common.Entities.GameMilestoneMatch();
                gameMatch.game_milestone_id = milestone0.game_milestone_id;
                gameMatch.game_id = newGame.game_id;
                gameMatch.match_code = matchT.match_code;
                gameMatch.golfer_1 = golfer_id_1;
                gameMatch.golfer_2 = golfer_id_2;
                gameMatch.sequence = milestone0.sequence;
                gameMatch.milestone_code = milestone0.milestone_code;
                gameMatch.golfer_1_score = 0;
                gameMatch.golfer_2_score = 0;
                gameMatch.final_indc = matchT.final_indc;
                gameMatch.winner = 0;
                gameMatch.status = "Approved";
                gameMatch.create_time = DateTime.Now;
                gameMatch.last_upt_time = DateTime.Now;
                gameMatch.game_milestone_matchT_id = matchT.game_milestone_matchT_id;

                _DbContext.GameMilestoneMatch.Add(gameMatch);
            }

            //for open tournament, populate JoinOpenTournament table for each golfer
            var joinOpenTournament0 = new JoinOpenTournament()
            {
                

            };
            _DbContext.SaveChanges();
            
            return count;

        }
    
    }
}
