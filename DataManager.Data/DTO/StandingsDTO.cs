using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.DTO
{
    public class StandingsDTO
    {
        public LeagueDTO League { get; set; }
        public ClubDTO Club { get; set; }
        public int LeaguePoints { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
    }
}
