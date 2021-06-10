using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    public class StandingsDAO
    {
        public LeagueDAO League { get; set; }
        public ClubDAO Club { get; set; }
        public int LeaguePoints { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }

        public StandingsDAO(StandingsDTO standingsDTO)
        {
            LeagueDAO leagueDAO = new LeagueDAO();
            ClubDAO clubDAO = new ClubDAO();
            League = leagueDAO;
            Club = clubDAO;
            LeaguePoints = standingsDTO.LeaguePoints;
            Status = standingsDTO.Status;
            Result = standingsDTO.Result;
        }
    }
}
