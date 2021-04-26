using DataManager.Data.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    class GeographicalDatabaseContext : IGeographicalContext
    {
        GeographicalDatabaseContext geographicalDatabaseContext = new GeographicalDatabaseContext();

        public IEnumerable<Primary_ColorDTO> GetAllColors(Primary_ColorDTO primary_Color)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContinentDTO> GetAllContinents(ContinentDTO continent)
        {
            List<ContinentDTO> continents = new List<ContinentDTO>();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getContinent = new MySqlCommand("SELECT * FROM `primary_color`", databaseConnection);
            try
            {
                databaseConnection.Open();
                getContinent.Prepare();
                var executeString = getContinent.ExecuteReader();
                while (executeString.Read())
                {
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

        public IEnumerable<CountryDTO> GetAllCountries(CountryDTO country)
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
                    ContinentDTO newContinent = new ContinentDTO();
                    Primary_ColorDTO newPrimary_Color = new Primary_ColorDTO();
                    country.Name = executeString.GetString(1);
                    newContinent.ContinentID = executeString.GetInt32(2);
                    newContinent = geographicalDatabaseContext.GetContinent(executeString.GetInt32(2), newContinent);
                    country.continent = newContinent;
                    newPrimary_Color.ColorID = executeString.GetInt32(3);
                    newPrimary_Color = geographicalDatabaseContext.GetPrimary_Color(executeString.GetInt32(3), newPrimary_Color);
                    country.primary_Color = newPrimary_Color;
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

        public ContinentDTO GetContinent(int id, ContinentDTO continent)
        {
            var result = GetAllContinents(continent).FirstOrDefault(c => c.ContinentID == id);
            return result;
        }

        public CountryDTO GetCountry(int id, CountryDTO countryDTO)
        {
            var result = GetAllCountries(countryDTO).FirstOrDefault(country => country.CountryID == id);
            return result;
        }

        public Primary_ColorDTO GetPrimary_Color(int id, Primary_ColorDTO primary_Color)
        {
            throw new NotImplementedException();
        }
    }
}
