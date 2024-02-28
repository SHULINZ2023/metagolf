using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace Common.BaseClasses
{
    public class User
    {
        [Key]
        public long UserSystemId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public long Level_id {get;set;} = 0;
        public int Scorepoint {get;set;}
        
    }
}
