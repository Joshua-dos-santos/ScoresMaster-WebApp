using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public Continent continent { get; set; }
        public Primary_Color primary_Color { get; set; }
        
        public Country(CountryDAO countryDAO)
        {
            Continent continents = new Continent();
            Primary_Color color = new Primary_Color();
            CountryID = countryDAO.CountryID;
            Name = countryDAO.Name;
            continent = continents;
            primary_Color = color;
        }
        public Country()
        {

        }
    }
}