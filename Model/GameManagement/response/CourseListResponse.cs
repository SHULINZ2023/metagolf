namespace GolfApi.Model.GameManagement.Response
{
    public class CourseListResponse
    {
        public long Area_id {get;set;} 
        public string Area_name {get;set;} 
        public long Golfcourse_id {get;set;}
        public string Golfcourse_name {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string Province {get;set;}
        
    }

}