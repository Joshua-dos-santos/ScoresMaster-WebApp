using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class MatchContainerFE
    {
        DataManager.Business.Containers.MatchContainer MatchContainer = new DataManager.Business.Containers.MatchContainer();
        ClubContainerFE clubContainerFE = new ClubContainerFE();
        
        public List<Match> GetAllMatches(int id)
        {
            List<Match> matches = new List<Match>();
            var match = MatchContainer.GetAllMatches(id);
            foreach (var m in match)
            {
                matches.Add(new Match(m) { Home_Team = clubContainerFE.GetClubByName(m.Home_Team.Name), Away_Team = clubContainerFE.GetClubByName(m.Away_Team.Name) });
            }
            return matches;
        }
    }
}