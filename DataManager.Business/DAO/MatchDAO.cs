using DataManager.Data.DTO;

namespace DataManager.Business.DAO
{
    public class MatchDAO
    {
        public int MatchID { get; set; }
        public string Home_Team { get; set; }
        public string Match_Start { get; set; }
        public string Away_Team { get; set; }

        public MatchDAO(MatchDTO matchDTO)
        {
            MatchID = matchDTO.MatchID;
            Home_Team = matchDTO.Home_Team;
            Match_Start = matchDTO.Match_Start;
            Away_Team = matchDTO.Away_Team;
        }
    }
}
