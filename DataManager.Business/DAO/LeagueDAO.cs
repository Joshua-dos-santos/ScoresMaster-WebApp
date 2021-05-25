using DataManager.Data.DTO;

namespace DataManager.Business.DAO
{
    public class LeagueDAO
    {
        public int LeagueID { get; set; }
        public string Name { get; set; }
        //public ClubDAO Current_Champion { get; set; }
        //public CountryDAO Nation { get; set; }

        public LeagueDAO(LeagueDTO leagueDTO)
        {
            //ClubDAO clubDAO = new ClubDAO();
            //CountryDAO countryDAO = new CountryDAO();
            LeagueID = leagueDTO.LeagueID;
            Name = leagueDTO.Name;
            //Current_Champion = clubDAO;
            //Nation = countryDAO;
        }
        public LeagueDAO()
        {

        }
    }
}
