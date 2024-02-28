using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class CourseHoleCoordinates
    {
        [Key]
        public long course_hole_coordinate_id { get; set; }
        public long golf_course_id { get; set; }
        public int course_hole_id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string moe {get;set;}
        public double maxdistance{get;set;} 
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}