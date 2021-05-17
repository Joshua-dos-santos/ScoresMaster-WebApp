using DataManager.Business.DAO;
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

        public Club(ClubDAO clubDAO)
        {
            ClubID = clubDAO.ClubID;
            Name = clubDAO.Name;
            //League = clubDAO.League;
        }

    }
}