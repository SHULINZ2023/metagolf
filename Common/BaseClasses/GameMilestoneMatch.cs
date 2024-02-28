using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameMilestoneMatch
    {
        [Key]
        public long game_milestone_match_id { get; set; }
        public long game_milestone_matchT_id { get; set; }
        public long game_milestone_id {get;set;}
        public long game_id {get;set;}
        public string match_code {get;set;} // milestone_code + 001 / 002  / 003 / 004
        public long golfer_1 { get; set; }
        public long golfer_2 { get; set; }
        public int sequence {get;set;}
        public string milestone_code {get;set;}
        public double golfer_1_score {get;set;}
        public double golfer_2_score {get;set;}
        public int final_indc {get;set;}
        public long winner {get;set;}
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}