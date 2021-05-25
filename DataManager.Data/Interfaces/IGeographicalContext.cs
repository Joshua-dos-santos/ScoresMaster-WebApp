using System.Collections.Generic;

namespace DataManager.Data
{
    public interface IGeographicalContext
    {
        IEnumerable<CountryDTO> GetAllCountries();
        CountryDTO GetCountry(int id);
        IEnumerable<ContinentDTO> GetAllContinents();
        ContinentDTO GetContinent(int id);
        IEnumerable<Primary_ColorDTO> GetAllColors();
        Primary_ColorDTO GetPrimary_Color(int id);
    }
}
