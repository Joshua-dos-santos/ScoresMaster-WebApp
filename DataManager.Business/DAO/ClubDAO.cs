using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    public class ClubDAO
    {
        public int ClubID { get; set; }
        public string Name { get; set; }
        public LeagueDAO League { get; set; }

        public ClubDAO(ClubDTO clubDTO)
        {
            LeagueDTO leagueDTO = new LeagueDTO();
            LeagueDAO leagueDAO = new LeagueDAO(leagueDTO);
            ClubID = clubDTO.ClubID;
            Name = clubDTO.Name;
            League = leagueDAO;
        }
    }
}
