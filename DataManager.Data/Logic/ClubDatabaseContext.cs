using DataManager.Data.DatabaseLogic;
using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataManager.Data.Logic
{
    public class ClubDatabaseContext : IClubContext
    {
        public IEnumerable<ClubDTO> GetAllClubs()
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
                    ClubDTO clubDTO = new ClubDTO();
                    LeagueDTO leagueDTO = new LeagueDTO();
                    clubDTO.ClubID = executeString.GetInt32(0);
                    clubDTO.Name = executeString.GetString(1);
                    clubDTO.League = leagueDatabaseContext.GetLeague(leagueDTO.LeagueID);
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

        public ClubDTO GetClub(string name)
        {
            ClubDTO club = new ClubDTO();
            MatchDTO matchDTO = new MatchDTO();
            LeagueDTO league = new LeagueDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getClubs = new MySqlCommand("SELECT * FROM `club` WHERE `club_name`=@val1", databaseConnection);
            getClubs.Parameters.AddWithValue("@val1", name);
            try
            {
                databaseConnection.Open();
                getClubs.Prepare();
                var executeString = getClubs.ExecuteReader();
                while (executeString.Read())
                {
                    club.ClubID = executeString.GetInt32(0);
                    club.Name = matchDTO.Home_Team;
                    club.League = league;
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return club;
        }
    }
}
