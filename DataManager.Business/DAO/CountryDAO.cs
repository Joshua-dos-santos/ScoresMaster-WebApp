using DataManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    public class CountryDAO
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ContinentDAO Continent { get; set; }
        public Primary_ColorDAO Primary_Color { get; set; }

        public CountryDAO(CountryDTO countryDTO)
        {
            ContinentDTO continentDTO = new ContinentDTO();
            Primary_ColorDTO primary_ColorDTO = new Primary_ColorDTO();

            ContinentDAO continentDAO = new ContinentDAO(continentDTO);
            Primary_ColorDAO primary_ColorDAO = new Primary_ColorDAO(primary_ColorDTO);

            CountryID = countryDTO.CountryID;
            Name = countryDTO.Name;
            Continent = continentDAO;
            Primary_Color = primary_ColorDAO;
        }
    }
}
