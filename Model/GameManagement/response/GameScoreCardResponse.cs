using Common.Entities;
namespace GolfApi.Model.GameManagement.Response
{
    public class GameScoreCardResponse
    {   public long game_id {get;set;}
        public Games game {get;set;}
        public GameMilestoneMatch gameMatch {get;set;}
        public GameMatchScoreCard gameScoreCard {get;set;} 
        public List<GameMatchStroke> gameStrokes {get;set;}
        public string golf_course_name {get;set;}
        public List<CourseTees> courseHoleTees {get;set;} 
        public List<CourseHoles> courseHoles {get;set;}
        public List<GameHoleRoadmap> gameHoleRoadmaps {get;set;}
    }

}