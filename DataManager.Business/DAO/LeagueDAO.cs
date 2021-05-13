using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    class LeagueDAO
    {
        public int LeagueID { get; set; }
        public string Name { get; set; }

        public LeagueDAO(LeagueDTO leagueDTO)
        {
            LeagueID = leagueDTO.LeagueID;
            Name = leagueDTO.Name;
        }
    }
}
