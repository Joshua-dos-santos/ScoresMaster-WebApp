using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.DatabaseLogic
{
    class LeagueDatabaseContext : ILeagueContext
    {
        public IEnumerable<LeagueDTO> GetAllLeagues(LeagueDTO leagueDTO)
        {
            List<LeagueDTO> leagues = new List<LeagueDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getLeagues = new MySqlCommand("SELECT * FROM `league`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getLeagues.Prepare();
                var executeString = getLeagues.ExecuteReader();
                while (executeString.Read())
                {
                    leagueDTO.LeagueID = executeString.GetInt32(0);
                    leagueDTO.Name = executeString.GetString(1);
                    leagues.Add(leagueDTO);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return leagues;
        }

        public LeagueDTO GetLeague(int id, LeagueDTO leagueDTO)
        {
            var result = GetAllLeagues(leagueDTO).FirstOrDefault(league => league.LeagueID == id);
            return result;
        }
    }
}
