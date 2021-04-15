using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Club
    {
        public int ClubID { get; set; }
        public string Name { get; set; }
        public League League { get; set; }
    }
}