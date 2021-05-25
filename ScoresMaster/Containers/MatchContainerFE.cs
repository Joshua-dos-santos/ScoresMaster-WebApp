using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class MatchContainerFE
    {
        DataManager.Business.Containers.MatchContainer MatchContainer = new DataManager.Business.Containers.MatchContainer();

        
        public List<Match> GetAllMatches(int id)
        {
            List<Match> matches = new List<Match>();
            var match = MatchContainer.GetAllMatches(id);
            foreach (var m in match)
            {
                matches.Add(new Match(m));
            }
            return matches;
        }
    }
}