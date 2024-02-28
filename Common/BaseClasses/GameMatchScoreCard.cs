using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameMatchScoreCard
    {
        [Key]
        public long game_match_score_card_id { get; set; }
        public long game_milestone_match_id { get; set; }
        public long golfer_id {get;set;}
        public int hole_1_status {get;set;} = 0;
        public double hole_1_score {get;set;} = 0;
        public int hole_2_status {get;set;} = 0;
        public double hole_2_score {get;set;} = 0;
        public int hole_3_status {get;set;} = 0;
        public double hole_3_score {get;set;} = 0;
        public int hole_4_status {get;set;} = 0;
        public double hole_4_score {get;set;} = 0;
        public int hole_5_status {get;set;} = 0;
        public double hole_5_score {get;set;} = 0;
        
        public int hole_6_status {get;set;} = 0;
        public double hole_6_score {get;set;} = 0;
        
        public int hole_7_status {get;set;} = 0;
        public double hole_7_score {get;set;} = 0; 

        public int hole_8_status {get;set;} = 0;
        public double hole_8_score {get;set;} = 0;


        public int hole_9_status {get;set;} = 0;
        public double hole_9_score {get;set;} = 0;

        public int hole_10_status {get;set;} = 0;
        public double hole_10_score {get;set;} = 0;

        public int hole_11_status {get;set;} = 0;
        public double hole_11_score {get;set;} = 0;

        public int hole_12_status {get;set;} = 0;
        public double hole_12_score {get;set;} = 0;

        public int hole_13_status {get;set;} = 0;
        public double hole_13_score {get;set;} = 0;

        public int hole_14_status {get;set;} = 0;
        public double hole_14_score {get;set;} = 0;

        public int hole_15_status {get;set;} = 0 ;
        public double hole_15_score {get;set;} = 0; 

        public int hole_16_status {get;set;} = 0;
        public double hole_16_score {get;set;} = 0;

        public int hole_17_status {get;set;} = 0;
        public double hole_17_score {get;set;} = 0;

        public int hole_18_status {get;set;} = 0;
        public double hole_18_score {get;set;} = 0;
        public double score {get;set;} =0 ;
        public long course_hole_id {get;set;} = 1;
        public long roadmap_sequence {get;set;} = 0;
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}