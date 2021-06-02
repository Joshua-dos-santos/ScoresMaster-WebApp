using DataManager.Data.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataManager.Data
{
    public class GeographicalDatabaseContext : IGeographicalContext
    {
        public ContinentDTO GetContinent(int id)
        {
            ContinentDTO continent = new ContinentDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getContinent = new MySqlCommand("SELECT * FROM `continent` WHERE `unique_id`=@val1", databaseConnection);
            getContinent.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getContinent.Prepare();
                var executeString = getContinent.ExecuteReader();
                while (executeString.Read())
                {
                    continent.ContinentID = executeString.GetInt32(0);
                    continent.Continents = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return continent;
        }

        public IEnumerable<CountryDTO> GetAllCountries()
        {
            List<CountryDTO> countries = new List<CountryDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getCountries = new MySqlCommand("SELECT * FROM `country`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getCountries.Prepare();
                var executeString = getCountries.ExecuteReader();
                while (executeString.Read())
                {
                    CountryDTO countryDTO = new CountryDTO();
                    ContinentDTO continentDTO = new ContinentDTO();
                    Primary_ColorDTO primary_ColorDTO = new Primary_ColorDTO();
                    countryDTO.CountryID = executeString.GetInt32(0);
                    countryDTO.Name = executeString.GetString(1);
                    continentDTO = GetContinent(executeString.GetInt32(2));
                    countryDTO.continent = continentDTO;
                    primary_ColorDTO = GetPrimary_Color(executeString.GetInt32(3));
                    countryDTO.Primary_Color = primary_ColorDTO;
                    countries.Add(countryDTO);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return countries;
        }
        public CountryDTO GetCountry(int id)
        {
            CountryDTO country = new CountryDTO();
            ContinentDTO newContinent = new ContinentDTO();
            Primary_ColorDTO newPrimary_Color = new Primary_ColorDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getPosition = new MySqlCommand("SELECT * FROM `country` WHERE unique_id= @val1", databaseConnection);
            getPosition.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getPosition.Prepare();
                var executeString = getPosition.ExecuteReader();
                while (executeString.Read())
                {
                    country.CountryID = executeString.GetInt32(0);
                    country.Name = executeString.GetString(1);
                    newContinent.ContinentID = executeString.GetInt32(2);
                    newContinent = GetContinent(executeString.GetInt32(2));
                    country.continent = newContinent;
                    newPrimary_Color.ColorID = executeString.GetInt32(3);
                    newPrimary_Color = GetPrimary_Color(executeString.GetInt32(3));
                    country.Primary_Color = newPrimary_Color;
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return country;
        }

        public Primary_ColorDTO GetPrimary_Color(int id)
        {
            Primary_ColorDTO primary_Color = new Primary_ColorDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getColor = new MySqlCommand("SELECT * FROM `primary_color` WHERE `unique_id`=@val1", databaseConnection);
            getColor.Parameters.AddWithValue("@val1", id);
            try
            {
                databaseConnection.Open();
                getColor.Prepare();
                var executeString = getColor.ExecuteReader();
                while (executeString.Read())
                {
                    primary_Color.ColorID = executeString.GetInt32(0);
                    primary_Color.Colors = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return primary_Color;
        }
    }
}
