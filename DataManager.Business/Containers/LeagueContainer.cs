using DataManager.Business.DAO;
using DataManager.Data.DatabaseLogic;
using DataManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.Containers
{
    public class LeagueContainer
    {
        LeagueDatabaseContext context = new LeagueDatabaseContext();
        ClubContainer clubContainer = new ClubContainer();
        GeographicalContainer geographicalContainer = new GeographicalContainer();

        public List<LeagueDAO> GetAllLeagues()
        {
            LeagueRepository repo = new LeagueRepository(context);
            List<LeagueDAO> leagues = new List<LeagueDAO>();
            var league = repo.GetAllLeagues();
            foreach(var l in league)
            {
                leagues.Add(new LeagueDAO(l));
            }
            return leagues;
        }

        public LeagueDAO GetLeague(int id)
        {
            LeagueRepository repo = new LeagueRepository(context);
            var league = repo.GetLeague(id);
            LeagueDAO leagueDAO = new LeagueDAO(league);
            return leagueDAO;
        }
    }
}
