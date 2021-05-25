using DataManager.Business.DAO;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class GeographicalContainer
    {
        Data.GeographicalDatabaseContext GeographicalDatabaseContext = new Data.GeographicalDatabaseContext();

        public List<CountryDAO> GetAllCountries()
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            List<CountryDAO> countries = new List<CountryDAO>();
            var country = repo.GetAllCountries();
            foreach(var c in country)
            {
                countries.Add(new CountryDAO(c) { Continent = GetContinent(c.continent.ContinentID), Primary_Color = GetPrimary_Color(c.Primary_Color.ColorID) });
            }
            return countries;
        }

        public CountryDAO GetCountry(int id)
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            var country = repo.GetCountry(id);
            CountryDAO countryDAO = new CountryDAO(country) { Continent = GetContinent(country.continent.ContinentID), Primary_Color = GetPrimary_Color(country.Primary_Color.ColorID)};
            return countryDAO;
        }

        public List<ContinentDAO> GetAllContinents()
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            List<ContinentDAO> continents = new List<ContinentDAO>();
            var continent = repo.GetAllContinents();
            foreach(var c in continent)
            {
                continents.Add(new ContinentDAO(c));
            }
            return continents;
        }

        public ContinentDAO GetContinent(int id)
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            var continent = repo.GetContinent(id);
            ContinentDAO continentDAO = new ContinentDAO(continent);
            return continentDAO;
        }

        public List<Primary_ColorDAO> GetAllColors()
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            List<Primary_ColorDAO> primary_Colors = new List<Primary_ColorDAO>();
            var primary_color = repo.GetAllColors();
            foreach(var color in primary_color)
            {
                primary_Colors.Add(new Primary_ColorDAO(color));
            }
            return primary_Colors;
        }

        public Primary_ColorDAO GetPrimary_Color(int id)
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            var primary_color = repo.GetPrimary_Color(id);
            Primary_ColorDAO primary_ColorDAO = new Primary_ColorDAO(primary_color);
            return primary_ColorDAO;
        }
    }
}
