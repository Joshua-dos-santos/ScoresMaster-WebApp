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
        public string Shirt_Number { get; set; }
        public Position Position { get; set; }
        public Country Nationality { get; set; }
        public Club Club { get; set; }
        public DateTime Birth_Day { get; set; } 
    }
}