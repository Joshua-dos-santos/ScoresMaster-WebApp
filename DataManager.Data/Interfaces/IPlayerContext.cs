using DataManager.Data.DTO;
using System.Collections.Generic;

namespace DataManager.Data.Interfaces
{
    interface IPlayerContext
    {
        IEnumerable<PlayerDTO> GetAllPlayers(int id);
        PlayerDTO GetPlayer(int clubID, int id);
        IEnumerable<PositionDTO> GetAllPositions();
        PositionDTO GetPosition(int id);
    }
}
