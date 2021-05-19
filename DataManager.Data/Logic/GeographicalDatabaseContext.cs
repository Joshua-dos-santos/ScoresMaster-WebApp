using DataManager.Data.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    public class GeographicalDatabaseContext : IGeographicalContext
    {

        public IEnumerable<Primary_ColorDTO> GetAllColors()
        {
            List<Primary_ColorDTO> Colors = new List<Primary_ColorDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getColor = new MySqlCommand("SELECT * FROM `primary_color`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getColor.Prepare();
                var executeString = getColor.ExecuteReader();
                while (executeString.Read())
                {
                    Primary_ColorDTO primary_Color = new Primary_ColorDTO();
                    primary_Color.ColorID = executeString.GetInt32(0);
                    primary_Color.Colors = executeString.GetString(1);
                    Colors.Add(primary_Color);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return Colors;
        }

        public IEnumerable<ContinentDTO> GetAllContinents()
        {
            List<ContinentDTO> continents = new List<ContinentDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getContinent = new MySqlCommand("SELECT * FROM `continent`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getContinent.Prepare();
                var executeString = getContinent.ExecuteReader();
                while (executeString.Read())
                {
                    ContinentDTO continent = new ContinentDTO();
                    continent.ContinentID = executeString.GetInt32(0);
                    continent.Continents = executeString.GetString(1);
                    continents.Add(continent);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return continents;
        }

        public IEnumerable<CountryDTO> GetAllCountries()
        {
            List<CountryDTO> countries = new List<CountryDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getCountry = new MySqlCommand("SELECT * FROM `country`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getCountry.Prepare();
                var executeString = getCountry.ExecuteReader();
                while (executeString.Read())
                {
                    CountryDTO country = new CountryDTO();
                    ContinentDTO newContinent = new ContinentDTO();
                    Primary_ColorDTO newPrimary_Color = new Primary_ColorDTO();
                    country.CountryID = executeString.GetInt32(0);
                    country.Name = executeString.GetString(1);
                    newContinent.ContinentID = executeString.GetInt32(2);
                    newContinent = GetContinent(executeString.GetInt32(2));
                    country.continent = newContinent;
                    newPrimary_Color.ColorID = executeString.GetInt32(3);
                    newPrimary_Color = GetPrimary_Color(executeString.GetInt32(3));
                    country.Primary_Color = newPrimary_Color;
                    countries.Add(country);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return countries;
        }

        public ContinentDTO GetContinent(int id)
        {
            var result = GetAllContinents().FirstOrDefault(continent => continent.ContinentID == id);
            return result;
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
            var result = GetAllColors().FirstOrDefault(color => color.ColorID == id);
            return result;
        }
    }
}
