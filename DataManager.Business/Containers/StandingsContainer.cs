using DataManager.Business.DAO;
using DataManager.Data.Logic;
using DataManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.Containers
{
    public class StandingsContainer
    {
        StandingsAPIContext standingsAPIContext = new StandingsAPIContext();
        LeagueContainer leagueContainer = new LeagueContainer();
        ClubContainer clubContainer = new ClubContainer();

        public List<StandingsDAO> GetAllStandings(int id, int clubAmount)
        {
            StandingsRepository repo = new StandingsRepository(standingsAPIContext);
            List<StandingsDAO> standings = new List<StandingsDAO>();
            var standing = repo.GetAllStandings(id, clubAmount);
            foreach(var s in standing)
            {
                standings.Add(new StandingsDAO(s) { League = leagueContainer.GetLeague(s.League.LeagueID), Club = clubContainer.GetClubByName(s.Club.Name) });
            }
            return standings;
        }
    }
}
