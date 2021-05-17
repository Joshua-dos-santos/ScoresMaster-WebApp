using DataManager.Business.DAO;
using DataManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
