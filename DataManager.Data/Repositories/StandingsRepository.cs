using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    public class StandingsRepository
    {
        private IStandingsContext context;

        public StandingsRepository(StandingsAPIContext context)
        {
            this.context = context;
        }

        public List<StandingsDTO> GetAllStandings(int id, int clubAmount)
        {
            return context.GetAllStandings(id, clubAmount).ToList();
        }

        public string GetStandingsClub(int id)
        {
            return context.GetStandigsClub(id);
        }
    }
}
