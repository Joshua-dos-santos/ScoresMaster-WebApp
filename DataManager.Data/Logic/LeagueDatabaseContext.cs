using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataManager.Data.DatabaseLogic
{
    public class LeagueDatabaseContext : ILeagueContext
    {
        public IEnumerable<LeagueDTO> GetAllLeagues()
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
                    LeagueDTO leagueDTO = new LeagueDTO();
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

        public LeagueDTO GetLeague(int id)
        {
            var result = GetAllLeagues().FirstOrDefault(league => league.LeagueID == id);
            return result;
        }
    }
}
