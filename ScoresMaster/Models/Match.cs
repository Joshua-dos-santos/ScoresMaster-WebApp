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
        public Club Home_Team { get; set; }
        [DisplayName("Match Time")]
        public string Match_Start { get; set; }
        public string Match_Status { get; set; }
        [DisplayName("Away team")]
        public Club Away_Team { get; set; }

        public Match(MatchDAO matchDAO)
        {
            Club Home_team = new Club();
            Club Away_team = new Club();
            MatchID = matchDAO.MatchID;
            Home_Team = Home_team;
            Match_Start = matchDAO.Match_Start;
            Match_Status = matchDAO.Match_Status;
            Away_Team = Away_team;
        }
        public Match()
        {

        }

    }

}