using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Logic;
using System.Collections.Generic;
using System.Linq;

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
       
        public PositionDTO GetPosition(int id)
        {
            return context.GetPosition(id);
        }
    }
}
