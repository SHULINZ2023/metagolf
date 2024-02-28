using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.BaseClasses
{
    public class GameMatchStroke
    {
        [Key]
        public long game_match_stroke_id{ get; set;}
        public long game_match_score_card_id {get;set;}
        public long golf_course_hole_id { get; set;}
        public long game_hole_roadmap_id {get;set;}
        public int stroke_seqno {get;set;}
        public double latitude {get;set;}
        public double longitude {get;set;}
        public DateTime stoke_time {get;set;}
        public long course_tee_id {get;set;}
        public double distance {get;set;}
        public string location {get;set;}
        public int isin_putter_length {get;set;}
        public int isin_hole {get;set;}
        public string status {get;set;}
        public DateTime create_time { get; set; } = DateTime.UtcNow;
        public DateTime last_upt_time { get; set; } = DateTime.UtcNow;
        public int scorepoint {get;set;}
        
        
    }
}