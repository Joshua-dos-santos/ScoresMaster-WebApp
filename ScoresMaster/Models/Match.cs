using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ScoresMaster.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        [DisplayName("Home team")]
        public string Home_Team { get; set; }
        [DisplayName("Match Time")]
        public string Match_Start { get; set; }
        [DisplayName("Away team")]
        public string Away_Team { get; set; }

        public Match(MatchDAO matchDAO)
        {
            MatchID = matchDAO.MatchID;
            Home_Team = matchDAO.Home_Team;
            Match_Start = matchDAO.Match_Start;
            Away_Team = matchDAO.Away_Team;
        }
        public Match()
        {

        }

    }

}