using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameHoleRoadmap
    {
        [Key]
        public long game_hole_roadmap_id { get; set; }
        public long game_type_id { get; set; }
        public int sequence {get;set;}
        public string roadmap_code {get;set;}
        public int shot_limit {get;set;}
        public int end_indc {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}