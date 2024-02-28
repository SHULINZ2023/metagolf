using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class ThePerfectGameUser : BaseClasses.ThePerfectGameUser
    {
        [ForeignKey("UserSystemId")]
        public User User { get; set; }
        public ICollection<ThePerfectGameStroke> ThePerfectGameStrokes { get; set; }
    }
}
