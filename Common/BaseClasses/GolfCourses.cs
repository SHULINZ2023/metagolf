 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GolfCourses
    {
        [Key]
        public long golf_course_id { get; set; }
        public string golf_course_code { get; set; }
        public string golf_course_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string location { get; set; }
        public long area_id { get; set; }
        public string comments { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string contact_person { get; set; }
        public int par_9 { get; set; }
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}