using DataManager.Business.Containers;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Containers
{
    public class StandingsContainerFE
    {
        StandingsContainer standingsContainer = new StandingsContainer();
        LeagueContainerFE leagueContainerFE = new LeagueContainerFE();
        ClubContainerFE clubContainerFE = new ClubContainerFE();

        public List<Standings> GetAllStandings(int id, int clubAmount)
        {
            List<Standings> standings = new List<Standings>();
            var standing = standingsContainer.GetAllStandings(id, clubAmount);
            foreach (var s in standing)
            {
                standings.Add(new Standings(s) { League = leagueContainerFE.GetLeague(s.League.LeagueID), Club = clubContainerFE.GetClubByName(s.Club.Name) });
            }
            return standings;
        }
    }
}