using System.Collections.Generic;

namespace DataManager.Data
{
    public interface IGeographicalContext
    {
        CountryDTO GetCountry(int id);
        IEnumerable<CountryDTO> GetAllCountries();
        ContinentDTO GetContinent(int id);
        Primary_ColorDTO GetPrimary_Color(int id);
    }
}
