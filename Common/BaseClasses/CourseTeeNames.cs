using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class CourseTeeNames
    {
        [Key]
        public long course_teename_id { get; set; }
        public long golf_course_id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}