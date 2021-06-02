using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataManager.Data.Logic
{
    public class PlayerDatabaseContext : IPlayerContext
    {

        GeographicalDatabaseContext GeographicalDatabaseContext = new GeographicalDatabaseContext();
        public IEnumerable<PlayerDTO> GetAllPlayersByClub(int id)
        {
            
            List<PlayerDTO> Players = new List<PlayerDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPlayers = new MySqlCommand("SELECT * FROM `player` WHERE `club` = @val1", databaseConnection);
            getPlayers.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getPlayers.Prepare();
                var executeString = getPlayers.ExecuteReader();

                while (executeString.Read())
                {
                    PlayerDTO playerDTO = new PlayerDTO();
                    PositionDTO newPosition = new PositionDTO();
                    CountryDTO newCountry = new CountryDTO();
                    playerDTO.PlayerID = executeString.GetInt32(0);
                    playerDTO.First_Name = executeString.GetString(1);
                    playerDTO.Last_Name = executeString.GetString(2);
                    playerDTO.Shirt_Number = executeString.GetString(3);
                    newPosition.unique_id = executeString.GetInt32(4);
                    newPosition = GetPosition(newPosition.unique_id);
                    playerDTO.Position = newPosition;
                    newCountry.CountryID = executeString.GetInt32(5);
                    newCountry = GeographicalDatabaseContext.GetCountry(newCountry.CountryID);
                    playerDTO.Nationality = newCountry;
                    playerDTO.Birth_Day = executeString.GetString(7);
                    Players.Add(playerDTO);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return Players;
        }

        public IEnumerable<PlayerDTO> GetAllPlayersByCountry(int id)
        {
            List<PlayerDTO> Players = new List<PlayerDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPlayers = new MySqlCommand("SELECT * FROM `player` WHERE `nationality` = @val1", databaseConnection);
            getPlayers.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getPlayers.Prepare();
                var executeString = getPlayers.ExecuteReader();

                while (executeString.Read())
                {
                    PlayerDTO playerDTO = new PlayerDTO();
                    PositionDTO newPosition = new PositionDTO();
                    CountryDTO newCountry = new CountryDTO();
                    playerDTO.PlayerID = executeString.GetInt32(0);
                    playerDTO.First_Name = executeString.GetString(1);
                    playerDTO.Last_Name = executeString.GetString(2);
                    playerDTO.Shirt_Number = executeString.GetString(3);
                    newPosition.unique_id = executeString.GetInt32(4);
                    newPosition = GetPosition(newPosition.unique_id);
                    playerDTO.Position = newPosition;
                    newCountry.CountryID = executeString.GetInt32(5);
                    newCountry = GeographicalDatabaseContext.GetCountry(newCountry.CountryID);
                    playerDTO.Nationality = newCountry;
                    playerDTO.Birth_Day = executeString.GetString(7);
                    Players.Add(playerDTO);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return Players;
        }
        public PlayerDTO GetPlayer(int id)
        {
            PlayerDTO playerDTO = new PlayerDTO();
            PositionDTO positionDTO = new PositionDTO();
            CountryDTO newCountry = new CountryDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPlayer = new MySqlCommand("SELECT * FROM `player` WHERE unique_id= @val1", databaseConnection);
            getPlayer.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getPlayer.Prepare();
                var executeString = getPlayer.ExecuteReader();
                while (executeString.Read())
                {
                    playerDTO.PlayerID = executeString.GetInt32(0);
                    playerDTO.First_Name = executeString.GetString(1);
                    playerDTO.Last_Name = executeString.GetString(2);
                    playerDTO.Shirt_Number = executeString.GetString(3);
                    positionDTO.unique_id = executeString.GetInt32(4);
                    positionDTO = GetPosition(positionDTO.unique_id);
                    playerDTO.Position = positionDTO;
                    newCountry.CountryID = executeString.GetInt32(5);
                    newCountry = GeographicalDatabaseContext.GetCountry(newCountry.CountryID);
                    playerDTO.Nationality = newCountry;
                    playerDTO.Birth_Day = executeString.GetString(7);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return playerDTO;
        }
        public PositionDTO GetPosition(int id)
        {
            PositionDTO positionDTO = new PositionDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPosition = new MySqlCommand("SELECT * FROM `position` WHERE unique_id= @val1", databaseConnection);
            getPosition.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getPosition.Prepare();
                var executeString = getPosition.ExecuteReader();
                while (executeString.Read())
                {
                    positionDTO.unique_id = executeString.GetInt32(0);
                    positionDTO.Positions = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return positionDTO;
        }
    }
}
