using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class League
    {
        public int LeagueID { get; set; }
        public string Name { get; set; }
        //public Club Current_Champion { get; set; }
        //public Country Nation { get; set; }

        public League(LeagueDAO leagueDAO)
        {
            //Club club = new Club();
            Country country = new Country();
            LeagueID = leagueDAO.LeagueID;
            Name = leagueDAO.Name;
            //Current_Champion = club;
            //Nation = country;
        }
    }
}
