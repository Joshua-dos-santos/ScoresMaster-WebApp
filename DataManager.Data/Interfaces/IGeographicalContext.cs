using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    interface IGeographicalContext
    {
        IEnumerable<CountryDTO> GetAllCountries(CountryDTO country);
        CountryDTO GetCountry(int id, CountryDTO country);
        IEnumerable<ContinentDTO> GetAllContinents(ContinentDTO continent);
        ContinentDTO GetContinent(int id, ContinentDTO continent);
        IEnumerable<Primary_ColorDTO> GetAllColors(Primary_ColorDTO primary_Color);
        Primary_ColorDTO GetPrimary_Color(int id, Primary_ColorDTO primary_Color);
    }
}
