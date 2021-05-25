using DataManager.Data.DTO;
using System.Collections.Generic;

namespace DataManager.Data.Interfaces
{
    public interface IMatchContext
    {
        IEnumerable<MatchDTO> GetAllMatches(int id);
    }
}
