using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Standings
    {
        public League League { get; set; }
        public Club Club { get; set; }
        [Display(Name = "Points")]
        public int LeaguePoints { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }

        public Standings(StandingsDAO standingsDAO)
        {
            League league = new League();
            Club club = new Club();
            League = league;
            Club = club;
            LeaguePoints = standingsDAO.LeaguePoints;
            Status = standingsDAO.Status;
            Result = standingsDAO.Result;
        }
        public Standings()
        {

        }
    }
}