using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class GeographicalContainerFE
    {
        DataManager.Business.Containers.GeographicalContainer GeographicalContainer = new DataManager.Business.Containers.GeographicalContainer();

        public Country GetCountry(int id)
        {
            var country = GeographicalContainer.GetCountry(id);
            Country countries = new Country(country) { continent = GetContinent(country.Continent.ContinentID), primary_Color = GetPrimary_Color(country.Primary_Color.ColorID) };
            return countries;
        }
        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            var Countries = GeographicalContainer.GetAllCountries();
            foreach (var country in Countries)
            {
                countries.Add(new Country(country) { continent = GetContinent(country.Continent.ContinentID), primary_Color = GetPrimary_Color(country.Primary_Color.ColorID) });
            }
            return countries;
        }

        public Continent GetContinent(int id)
        {
            var continent = GeographicalContainer.GetContinent(id);
            Continent continentDAO = new Continent(continent);
            return continentDAO;
        }

        public Primary_Color GetPrimary_Color(int id)
        {
            var primary_color = GeographicalContainer.GetPrimary_Color(id);
            Primary_Color primary_ColorDAO = new Primary_Color(primary_color);
            return primary_ColorDAO;
        }
    }
}