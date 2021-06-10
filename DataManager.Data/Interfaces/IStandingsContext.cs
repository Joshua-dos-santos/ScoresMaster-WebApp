using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Interfaces
{
    public interface IStandingsContext
    {
        IEnumerable<StandingsDTO> GetAllStandings(int id, int clubAmount);

        string GetStandigsClub(int id);
    }
}
