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
        IEnumerable<PlayerDTO> GetAllPlayers(PlayerDTO playerDTO, PositionDTO position, CountryDTO countryDTO);
        PlayerDTO GetPlayer(int id, PlayerDTO playerDTO, PositionDTO position, CountryDTO countryDTO);
        IEnumerable<PositionDTO> GetAllPositions(PositionDTO positionDTO);
        PositionDTO GetPosition(int id, PositionDTO positionDTO);
    }
}
