using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    public class PlayerRepository
    {
        private IPlayerContext context;

        public PlayerRepository(PlayerDatabaseContext context)
        {
            this.context = context;
        }

        public List<PlayerDTO> GetAllPlayers(int id)
        {
            return context.GetAllPlayers(id).ToList();
        }
        public PlayerDTO GetPlayer(int clubID, int id)
        {
            return context.GetPlayer(clubID, id);
        }
        public List<PositionDTO> GetAllPositions()
        {
            return context.GetAllPositions().ToList();
        }
        public PositionDTO GetPosition(int id)
        {
            return context.GetPosition(id);
        }
    }
}
