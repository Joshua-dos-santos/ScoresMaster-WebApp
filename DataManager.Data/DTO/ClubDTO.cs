using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.DTO
{
    class ClubDTO
    {
        public int ClubID { get; set; }
        public string Name { get; set; }
        public LeagueDTO League { get; set; }

    }
}
