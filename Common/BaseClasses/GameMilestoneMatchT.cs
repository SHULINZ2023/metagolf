using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameMilestoneMatchT
    {
        [Key]
        public long game_milestone_matchT_id { get; set; }
        public long game_milestoneT_id {get;set;}
        public string match_code {get;set;} // milestone_code + 001 / 002  / 003 / 004
        public string golfer_1 { get; set; }
        public string golfer_1_rule {get;set;}
        public string golfer_2 { get; set; }
        public string golfer_2_rule {get;set;}
        public int final_indc {get;set;}
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}