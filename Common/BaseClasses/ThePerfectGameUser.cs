using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.BaseClasses
{
    public class ThePerfectGameUser
    {
        [Key]
        public long ThePerfectGameUserSystemId { get; set; }
        public long MinDistanceForGoodShot { get; set; }
        public long UserSystemId { get; set; }
       

    }
}
