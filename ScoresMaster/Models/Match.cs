using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ScoresMaster.Models
{
    public class Match
    {
        [DisplayName("Home team")]
        public string Home_Team { get; set; }
        [DisplayName("Match Time")]
        public string Match_Start { get; set; }
        [DisplayName("Away team")]
        public string Away_Team { get; set; }

    }

}