using DataManager.Data.DTO;
using System.Collections.Generic;

namespace DataManager.Data.Interfaces
{
    interface IPlayerContext
    {
        IEnumerable<PlayerDTO> GetAllPlayers(int id);
        PositionDTO GetPosition(int id);
    }
}
