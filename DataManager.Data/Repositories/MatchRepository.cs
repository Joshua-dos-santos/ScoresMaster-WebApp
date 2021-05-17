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
    public class MatchRepository
    {
        private IMatchContext context;
        
        public MatchRepository(MatchAPIContext context)
        {
            this.context = context;
        }

        public List<MatchDTO>GetAllMatches(int id)
        {
            return context.GetAllMatches(id).ToList();
        }
    }
}
