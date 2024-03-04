using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class JoinOpenTournament
    {
        [Key]
        public long join_open_tournament_id {get;set;}
        public long game_id { get; set; }
        public long milestone_id {get;set;}
        public long golf_course_id { get; set; }
        public long game_type_id { get; set; }
        public DateTime game_date { get; set; }
        public long golfer_id{get;set;}
        public long start_half_id { get; set; }=1;
        public string status { get; set; } = "Approved";
        public DateTime create_time { get; set; } = DateTime.Now;
        public DateTime last_upt_time { get; set; } = DateTime.Now;
        
    }
}