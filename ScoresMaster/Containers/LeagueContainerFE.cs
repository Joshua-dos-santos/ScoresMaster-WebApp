using DataManager.Business.Containers;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Containers
{
    public class LeagueContainerFE
    {
        LeagueContainer LeagueContainer = new LeagueContainer();
        GeographicalContainerFE geographicalContainerFE = new GeographicalContainerFE();

        public List<League> GetAllLeagues()
        {
            List<League> leagues = new List<League>();
            var league = LeagueContainer.GetAllLeagues();
            foreach (var l in league)
            {
                leagues.Add(new League(l));
            }
            return leagues;
        }
        public League GetLeague(int id)
        {
            var league = LeagueContainer.GetLeague(id);
            League leagueDAO = new League(league);
            return leagueDAO;
        }
    }
}