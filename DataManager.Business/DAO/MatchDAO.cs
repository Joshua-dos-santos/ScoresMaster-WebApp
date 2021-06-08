using DataManager.Data.DTO;

namespace DataManager.Business.DAO
{
    public class MatchDAO
    {
        public int MatchID { get; set; }
        public ClubDAO Home_Team { get; set; }
        public string Match_Start { get; set; }
        public ClubDAO Away_Team { get; set; }

        public MatchDAO(MatchDTO matchDTO)
        {
            ClubDAO Home_team = new ClubDAO();
            ClubDAO Away_team = new ClubDAO();
            MatchID = matchDTO.MatchID;
            Home_Team = Home_team;
            Match_Start = matchDTO.Match_Start;
            Away_Team = Away_team;
        }
    }
}
