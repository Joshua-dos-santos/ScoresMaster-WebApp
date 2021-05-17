using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    class PlayerRepository
    {
        private IPlayerContext context;

        public PlayerRepository(IPlayerContext context)
        {
            this.context = context;
        }
        public PlayerRepository()
        {

        }

        public List<PlayerDTO> GetAllPlayers(PlayerDTO playerDTO, PositionDTO positionDTO, CountryDTO countryDTO)
        {
            return context.GetAllPlayers(playerDTO, positionDTO, countryDTO).ToList();
        }
        public PlayerDTO GetPlayer(int id, PlayerDTO playerDTO, PositionDTO position, CountryDTO countryDTO)
        {
            return context.GetPlayer(id, playerDTO, position, countryDTO);
        }
        public List<PositionDTO> GetAllPositions(PositionDTO positionDTO)
        {
            return context.GetAllPositions(positionDTO).ToList();
        }
        public PositionDTO GetPosition(int id, PositionDTO positionDTO)
        {
            return context.GetPosition(id, positionDTO);
        }
    }
}
