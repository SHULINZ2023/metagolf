using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class Games
    {
        [Key]
        public long game_id { get; set; }
        public string game_name{get;set;}
        public long golf_course_id { get; set; }
        public long game_type_id { get; set; }
        public DateTime game_date { get; set; }
        public int level_limit {get;set;}=0;
        public long start_half_id { get; set; }=1;
        public string status { get; set; } = "Approved";
        public DateTime create_time { get; set; } = DateTime.Now;
        public DateTime last_upt_time { get; set; } = DateTime.Now;
        public string creator {get;set;}
        public string golfhandle0{get;set;}="not defined";
        public string golfhandle1{get;set;}="not defined";
        public string golfhandle2{get;set;}="not defined";
        public string golfhandle3{get;set;}="not defined";
        public string golfhandle4{get;set;}="not defined";
        public string golfhandle5{get;set;}="not defined";
        public string golfhandle6{get;set;}="not defined";
        public string golfhandle7{get;set;}="not defined";
        
    }
}