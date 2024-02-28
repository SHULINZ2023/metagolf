using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class TournamenTypes
    {
        [Key]
        public long tournament_type_id { get; set; }
        public string tournament_type_name { get; set; } 
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}