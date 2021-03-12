using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class RegistrationModel
    {
        [DisplayName("First Name")]
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Birth_Day { get; set; }
    }
}