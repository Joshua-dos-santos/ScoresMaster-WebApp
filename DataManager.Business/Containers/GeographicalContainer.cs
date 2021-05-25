using DataManager.Business.DAO;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class GeographicalContainer
    {
        Data.GeographicalDatabaseContext GeographicalDatabaseContext = new Data.GeographicalDatabaseContext();

        public CountryDAO GetCountry(int id)
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            var country = repo.GetCountry(id);
            CountryDAO countryDAO = new CountryDAO(country) { Continent = GetContinent(country.continent.ContinentID), Primary_Color = GetPrimary_Color(country.Primary_Color.ColorID)};
            return countryDAO;
        }

        public ContinentDAO GetContinent(int id)
        {
            Data.GeographicalRepository repo = new Data.GeographicalRepository(GeographicalDatabaseContext);
            var continent = repo.GetContinent(id);
            ContinentDAO continentDAO = new ContinentDAO(continent);
            return continentDAO;
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
