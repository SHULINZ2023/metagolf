using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class Level
    {
        [Key]
        public long level_id { get; set; }
        public string level_name { get; set; }
        public long level_limit { get; set; }
        public string status { get; set; }
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}