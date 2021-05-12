using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    class CountryDAO
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ContinentDTO continent { get; set; }
        public Primary_ColorDAO primary_Color { get; set; }

        public CountryDAO(CountryDTO countryDTO)
        {
            this.CountryID = countryDTO.CountryID;
            this.Name = countryDTO.Name;
            this.continent = countryDTO.continent;
            this.primary_Color = countryDTO.primary_Color;
        }
    }
}
