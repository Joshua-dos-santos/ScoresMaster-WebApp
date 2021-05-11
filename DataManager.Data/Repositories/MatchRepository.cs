using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    class MatchRepository
    {
        private IMatchContext context;

        public List<MatchDTO>GetAllMatches(int id, MatchDTO matchDTO)
        {
            return context.GetAllMatches(id, matchDTO).ToList();
        }
    }
}
