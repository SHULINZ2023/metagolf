using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameMilestone
    {
        [Key]
        public long game_milestone_id { get; set; }
        public long game_milestoneT_id {get;set;}
        public long game_id {get;set;}
        public int handlesize {get;set;}
        public int sequence { get; set; }
        public string milestone_code {get;set;}
        public int final_indc {get;set;}
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}