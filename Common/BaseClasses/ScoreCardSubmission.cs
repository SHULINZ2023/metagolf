using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Text;

namespace Common.BaseClasses
{
    public class ScoreCardSubmission
    {
        [Key]
        public long ScoreCardSubmission_id { get; set; }
        [Required]
        public long Game_match_score_card_id { get; set; }
        public string ? Status {get;set;}
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        [Required]
        public long Game_Type_id {get;set;}
        [Required]
        public long Game_id {get;set;}
        
        
    }
}