using Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.BaseClasses
{
    public class ThePerfectGame
    {
        [Key]
        public long ThePerfectGameSystemId { get; set; }
        public string GameName {  get;set; }
        public int StartingHole { get; set; }
        public long GolfCourseSystemId { get; set; }
       
    }
}
