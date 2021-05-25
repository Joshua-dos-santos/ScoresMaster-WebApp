using DataManager.Business.DAO;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class MatchContainer
    {
       
        public List<MatchDAO> GetAllMatches(int id)
        {
            Data.Logic.MatchAPIContext context = new Data.Logic.MatchAPIContext();
            Data.Repositories.MatchRepository repo = new Data.Repositories.MatchRepository(context);
            
            List<MatchDAO> matches = new List<MatchDAO>();
            var matchDto = repo.GetAllMatches(id);
            foreach(var dto in matchDto)
            {
                matches.Add(new MatchDAO(dto));
            }
            return matches;
        }
    }
}
