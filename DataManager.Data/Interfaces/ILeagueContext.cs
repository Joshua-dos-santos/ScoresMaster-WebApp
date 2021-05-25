using DataManager.Data.DTO;
using System.Collections.Generic;

namespace DataManager.Data.Interfaces
{
    public interface ILeagueContext
    {
        IEnumerable<LeagueDTO> GetAllLeagues();
        LeagueDTO GetLeague(int id);
    }
}
