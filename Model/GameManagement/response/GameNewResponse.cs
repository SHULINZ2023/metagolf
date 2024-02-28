using Common.Entities;
namespace GolfApi.Model.GameManagement.Response
{
    public class GameNewResponse
    {   public List<Area>?  areas {get;set;}
        public List<GolfCourses> ? golfCourses {get;set;}

        public List<User> ? golfers {get;set;}
       
    }

}