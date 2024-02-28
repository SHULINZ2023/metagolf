using Common.Entities;
namespace GolfApi.Model.GameManagement.Response
{
    public class GolfCourseResponse
    {
        public long game_id {get;set;}
        public long game_type_id {get;set;}
        public long golf_course_id {get;set;}
        public string golf_course_name {get;set;}
        public List<CourseTees> courseHoleTees {get;set;} 
        public List<CourseHoles> courseHoles {get;set;}
        
        public List<GameHoleRoadmap> gameHoleRoadmaps {get;set;}
        
    }

}