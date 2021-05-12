using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Interfaces
{
    interface IClubContext
    {
        IEnumerable<ClubDTO> GetAllClubs(ClubDTO clubDTO, LeagueDTO leagueDTO);
        ClubDTO GetClub(string name, ClubDTO clubDTO, LeagueDTO leagueDTO);
    }
}
