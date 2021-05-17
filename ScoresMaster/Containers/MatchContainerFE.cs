using DataManager.Business;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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