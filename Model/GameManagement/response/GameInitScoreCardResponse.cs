using Common.Entities;
namespace GolfApi.Model.GameManagement.Response
{
    public class GameInitScoreCardResponse
    {   public GolfCourses ? GolfCourse {get;set;}
        public Games ? Game {get;set;}
        public User ? GameUser {get;set;}
        public User ? Opponent {get;set;}
        public GameMilestone ? Milestone{get;set;}
        public GameMilestoneMatch ? GameMatch {get;set;}
        public GameMatchScoreCard ? GameScoreCard {get;set;} 
        public Level userLevel {get;set;}
        public List<GameMatchStroke> ? GameStrokes {get;set;}

        public List<CourseTees> ? CourseHoleTees {get;set;} 
        public List<CourseHoles> ? CourseHoles {get;set;}
        public List<GameHoleRoadmap> ? GameHoleRoadmaps {get;set;}
    }

}