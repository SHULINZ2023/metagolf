using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class ThePerfectGameStroke : BaseClasses.ThePerfectGameStroke
    {

        [ForeignKey("GolfCourseHoleSystemId")]
        public CourseHoles CourseHoles { get; set; }
        [ForeignKey("ThePerfectGameUserSystemId")]
        public virtual ThePerfectGameUser ThePerfectGameUser { get; set; }
    }
}
