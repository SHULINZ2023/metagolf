namespace GolfApi.Model.GameManagement.Request
{
    public class NewGameRequest
    {
        public long game_type_id {get;set;} 
        public long golfcourse_id {get;set;}
        public DateTime game_date{get;set;}
        public string golfcourse_name{get;set;}
        public int half_course_id{get;set;}
        public string golfhandle1{get;set;} 
        public string golfhandle2{get;set;}
        public string golfhandle3{get;set;}
        public string golfhandle4{get;set;}
        public string golfhandle5{get;set;}
        public string golfhandle6{get;set;}
        public string golfhandle7{get;set;}
    }

}