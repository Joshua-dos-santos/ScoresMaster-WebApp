using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    class LeagueRepository
    {
        private ILeagueContext context;

        public LeagueRepository(ILeagueContext context)
        {
            this.context = context;
        }

        public List<LeagueDTO> GetAllLeagues(LeagueDTO leagueDTO)
        {
            return context.GetAllLeagues(leagueDTO).ToList();
        }

        public LeagueDTO GetLeague(int id, LeagueDTO leagueDTO)
        {
            return context.GetLeague(id, leagueDTO);
        }
    }
}
