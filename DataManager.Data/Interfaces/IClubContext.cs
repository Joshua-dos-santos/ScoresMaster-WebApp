using DataManager.Data.DTO;
using System.Collections.Generic;

namespace DataManager.Data.Interfaces
{
    public interface IClubContext
    {
        IEnumerable<ClubDTO> GetAllClubs();
        ClubDTO GetClub(string name);
    }
}
