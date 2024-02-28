using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class CourseTees
    {
        [Key]
        public long course_tee_id { get; set; }
        public long golf_course_id { get; set; }
        public int course_hole_no { get; set; }
        public string course_teename { get; set; }
        public double teedistance { get; set; } //yard
        public string status { get; set; }
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}