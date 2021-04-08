using System;
using System.Collections.Generic;

namespace ScoresMaster.Models
{
    public class Match
    {
        public List<Player> Home_Team { get; set; }
        public List<Player> Away_Team { get; set; }
        public int Matchcounter { get; set; }
    }

}