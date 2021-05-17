using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
