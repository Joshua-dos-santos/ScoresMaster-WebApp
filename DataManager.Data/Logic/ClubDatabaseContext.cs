using DataManager.Data.DatabaseLogic;
using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Logic
{
    class ClubDatabaseContext : IClubContext
    {
        public IEnumerable<ClubDTO> GetAllClubs(ClubDTO clubDTO, LeagueDTO leagueDTO)
        {
            LeagueDatabaseContext leagueDatabaseContext = new LeagueDatabaseContext();
            List<ClubDTO> clubs = new List<ClubDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getLeagues = new MySqlCommand("SELECT * FROM `league`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getLeagues.Prepare();
                var executeString = getLeagues.ExecuteReader();
                while (executeString.Read())
                {
                    clubDTO.ClubID = executeString.GetInt32(0);
                    clubDTO.Name = executeString.GetString(1);
                    clubDTO.League = leagueDatabaseContext.GetLeague(leagueDTO.LeagueID, leagueDTO);
                    clubs.Add(clubDTO);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return clubs;
        }

        public IEnumerable<ClubDTO> GetAllClubs(ClubDTO clubDTO)
        {
            throw new NotImplementedException();
        }

        public ClubDTO GetClub(string name, ClubDTO clubDTO)
        {
            var result = GetAllClubs(clubDTO).FirstOrDefault(club => club.Name == name);
            return result;
        }
    }
}
