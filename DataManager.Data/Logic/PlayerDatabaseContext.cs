using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Logic
{
    class PlayerDatabaseContext : IPlayerContext
    {
        private IPlayerContext playercontext;
        private IGeographicalContext context;
        public IEnumerable<PlayerDTO> GetAllPlayers(PlayerDTO playerDTO, PositionDTO positionDTO, CountryDTO countryDTO)
        {
            PlayerRepository playerRepository = new PlayerRepository(playercontext);
            GeographicalRepository geographicalRepository = new GeographicalRepository(context);
            List<PlayerDTO> Players = new List<PlayerDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPlayers = new MySqlCommand("SELECT * FROM `player`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getPlayers.Prepare();
                var executeString = getPlayers.ExecuteReader();

                while (executeString.Read())
                {
                    PositionDTO newPosition = new PositionDTO();
                    CountryDTO newCountry = new CountryDTO();
                    playerDTO.First_Name = executeString.GetString(1);
                    playerDTO.Last_Name = executeString.GetString(2);
                    playerDTO.Shirt_Number = executeString.GetString(3);
                    newPosition.unique_id = executeString.GetInt32(4);
                    positionDTO = playerRepository.GetPosition(newPosition.unique_id, positionDTO);
                    playerDTO.Position = positionDTO;
                    newCountry.CountryID = executeString.GetInt32(5);
                    newCountry = geographicalRepository.GetCountry(newCountry.CountryID, countryDTO);
                    playerDTO.Nationality = newCountry;
                    playerDTO.Birth_Day = executeString.GetDateTime(7);
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

        public IEnumerable<PositionDTO> GetAllPositions(PositionDTO positionDTO)
        {
            List<PositionDTO> positions = new List<PositionDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPosition = new MySqlCommand("SELECT * FROM `position`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getPosition.Prepare();
                var executeString = getPosition.ExecuteReader();
                while (executeString.Read())
                {
                    positionDTO.unique_id = executeString.GetInt32(0);
                    positionDTO.Positions = executeString.GetString(1);
                    positions.Add(positionDTO);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return positions;
        }

        public PlayerDTO GetPlayer(int id, PlayerDTO playerDTO, PositionDTO positionDTO, CountryDTO countryDTO)
        {
            var result = GetAllPlayers(playerDTO, positionDTO, countryDTO).FirstOrDefault(player => player.PlayerID == id);
            return result;
        }

        public PositionDTO GetPosition(int id, PositionDTO positionDTO)
        {
            var result = GetAllPositions(positionDTO).FirstOrDefault(position => position.unique_id == id);
            return result;
        }
    }
}
