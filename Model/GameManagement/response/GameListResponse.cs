namespace GolfApi.Model.GameManagement.Response
{
    public class GameListResponse
    {
        public long game_id {get;set;} 
        public string game_name {get;set;}
        public DateTime game_date{get;set;}
        public long game_type_id{get;set;}
        public long game_type_code{get;set;}
    }

}