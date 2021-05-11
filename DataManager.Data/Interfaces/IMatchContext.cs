using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Interfaces
{
    interface IMatchContext
    {
        IEnumerable<MatchDTO> GetAllMatches(int id, MatchDTO matchDTO);
    }
}
