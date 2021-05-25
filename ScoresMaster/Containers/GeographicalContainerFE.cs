using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class GeographicalContainerFE
    {
        DataManager.Business.Containers.GeographicalContainer GeographicalContainer = new DataManager.Business.Containers.GeographicalContainer();
        

        //public List<Country> GetAllCountries()
        //{
        //    List<Country> countries = new List<Country>();
        //    var country = GeographicalContainer.GetAllCountries();
        //    foreach(var c in country)
        //    {
        //        countries.Add(new Country(c) { continent = GetContinent(c.Continent.ContinentID), primary_Color = GetPrimary_Color(c.Primary_Color.ColorID)});
        //    }
        //    return countries;
        //}

        public Country GetCountry(int id)
        {
            var country = GeographicalContainer.GetCountry(id);
            Country countries = new Country(country) { continent = GetContinent(country.Continent.ContinentID), primary_Color = GetPrimary_Color(country.Primary_Color.ColorID) };
            return countries;
        }
        //public List<Continent> GetAllContinents()
        //{
        //    List<Continent> continents = new List<Continent>();
        //    var continent = GeographicalContainer.GetAllContinents();
        //    foreach (var c in continent)
        //    {
        //        continents.Add(new Continent(c));
        //    }
        //    return continents;
        //}

        public Continent GetContinent(int id)
        {
            var continent = GeographicalContainer.GetContinent(id);
            Continent continentDAO = new Continent(continent);
            return continentDAO;
        }

        //public List<Primary_Color> GetAllColors()
        //{
        //    List<Primary_Color> primary_Colors = new List<Primary_Color>();
        //    var primary_color = GeographicalContainer.GetAllColors();
        //    foreach (var color in primary_color)
        //    {
        //        primary_Colors.Add(new Primary_Color(color));
        //    }
        //    return primary_Colors;
        //}

        public Primary_Color GetPrimary_Color(int id)
        {
            var primary_color = GeographicalContainer.GetPrimary_Color(id);
            Primary_Color primary_ColorDAO = new Primary_Color(primary_color);
            return primary_ColorDAO;
        }
    }
}