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

        public List<PlayerDTO> GetAllPlayersByClub(int id)
        {
            return context.GetAllPlayersByClub(id).ToList();
        }

        public List<PlayerDTO> GetAllPlayersByCountry(int id)
        {
            return context.GetAllPlayersByCountry(id).ToList();
        }
        public PlayerDTO GetPlayer(int id)
        {
            return context.GetPlayer(id);
        }
       
        public PositionDTO GetPosition(int id)
        {
            return context.GetPosition(id);
        }
    }
}
