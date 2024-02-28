using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameTypes
    {
        [Key]
        public long game_type_id { get; set; }
        public long game_type_code { get; set; }
        public string comments { get; set; }
        public string status { get; set; }
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}