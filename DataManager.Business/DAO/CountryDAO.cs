using DataManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    class CountryDAO
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ContinentDAO continent { get; set; }
        public Primary_ColorDAO primary_Color { get; set; }

        public CountryDAO(CountryDTO countryDTO)
        {
            CountryID = countryDTO.CountryID;
            Name = countryDTO.Name;
            //continent = countryDTO.continent;
            //primary_Color = 
        }
    }
}
