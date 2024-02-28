using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.BaseClasses
{
    public class ThePerfectGameStroke

    {   
        [Key]
        public long ThePerfectGameStrokeSystemId { get; set; }
        public int StrokeNumber { get; set; }
        public long? StartingLong { get; set; }
        public long? StartingLat { get; set; }
        public long? EndingLong { get; set; }
        public long? EndingLat { get; set; }
        public decimal Distance { get; set; }
        public Enums.Enums.BallLie BallLie { get; set; }
        public long? GolfCourseHoleSystemId { get; set; }
       
        public long ThePerfectGameUserSystemId { get; set; }

    }
}
