using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    public class LeagueRepository
    {
        private ILeagueContext context;

        public LeagueRepository(ILeagueContext context)
        {
            this.context = context;
        }

        public List<LeagueDTO> GetAllLeagues()
        {
            return context.GetAllLeagues().ToList();
        }

        public LeagueDTO GetLeague(int id)
        {
            return context.GetLeague(id);
        }
    }
}
