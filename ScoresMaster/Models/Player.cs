using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Player
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Shirt_Number { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public string Club { get; set; }
        public DateTime Birth_Day { get; set; } 
    }
}