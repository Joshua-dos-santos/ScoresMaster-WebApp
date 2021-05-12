using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.DTO
{
    class MatchDAO
    {
        public int MatchID { get; set; }
        public string Home_Team { get; set; }
        public string Match_Start { get; set; }
        public string Away_Team { get; set; }
    }
}
