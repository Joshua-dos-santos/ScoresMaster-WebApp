using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Logic;
using System.Collections.Generic;
using System.Linq;

namespace DataManager.Data.Repositories
{
    public class ClubRepository
    {
        private IClubContext context;

        public ClubRepository(ClubDatabaseContext context)
        {
            this.context = context;
        }

        public List<ClubDTO> GetAllclubs()
        {
            return context.GetAllClubs().ToList();
        }

        public ClubDTO GetClub(string name)
        {
            return context.GetClub(name);
        }
    }
}
