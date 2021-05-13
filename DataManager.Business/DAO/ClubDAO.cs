using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    class ClubDAO
    {
        public int ClubID { get; set; }
        public string Name { get; set; }
        public LeagueDAO League { get; set; }

        public ClubDAO(ClubDTO clubDTO)
        {
            ClubID = clubDTO.ClubID;
            Name = clubDTO.Name;
            League = clubDTO.League;
        }
    }
}
