using DataManager.Data.DTO;
using System.Collections.Generic;

namespace DataManager.Data.Interfaces
{
    interface IPlayerContext
    {
        IEnumerable<PlayerDTO> GetAllPlayersByClub(int id);
        IEnumerable<PlayerDTO> GetAllPlayersByCountry(int id);
        PlayerDTO GetPlayer(int id);
        PositionDTO GetPosition(int id);
    }
}
