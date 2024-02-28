using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Text;

namespace Common.BaseClasses
{
    public class CourseHalf
    {
        [Key]
        public long course_half_id { get; set; }
        public long golf_course_id {get;set;}
        public string course_half_code { get; set; }
        
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}