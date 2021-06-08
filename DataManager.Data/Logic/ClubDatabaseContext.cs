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
            MySqlCommand getLeagues = new MySqlCommand("SELECT * FROM `club`", databaseConnection);
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
                    leagueDTO.LeagueID = executeString.GetInt32(2);
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

        public ClubDTO GetClubByName(string name)
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
                    club.Name = executeString.GetString(1); ;
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

        public ClubDTO GetClubByID(int id)
        {
            ClubDTO club = new ClubDTO();
            LeagueDTO league = new LeagueDTO();
            LeagueDatabaseContext context = new LeagueDatabaseContext();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getClubs = new MySqlCommand("SELECT * FROM `club` WHERE `unique_id`=@val1", databaseConnection);
            getClubs.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getClubs.Prepare();
                var executeString = getClubs.ExecuteReader();
                while (executeString.Read())
                {
                    club.ClubID = executeString.GetInt32(0);
                    club.Name = executeString.GetString(1);
                    club.League = context.GetLeague(executeString.GetInt32(2));
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
