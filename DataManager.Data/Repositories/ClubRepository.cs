using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    class ClubRepository
    {
        private IClubContext context;

        public ClubRepository(IClubContext context)
        {
            this.context = context;
        }

        public List<ClubDTO> GetAllclubs(ClubDTO clubDTO)
        {
            return context.GetAllClubs(clubDTO).ToList();
        }

        public ClubDTO GetClub(string name, ClubDTO clubDTO)
        {
            return context.GetClub(name, clubDTO);
        }
    }
}
