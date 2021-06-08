namespace DataManager.Data.DTO
{
    public class MatchDTO
    {
        public int MatchID { get; set; }
        public ClubDTO Home_Team { get; set; }
        public string Match_Start { get; set; }
        public ClubDTO Away_Team { get; set; }
    }
}
