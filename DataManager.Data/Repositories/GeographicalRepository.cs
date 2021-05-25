using System.Collections.Generic;
using System.Linq;

namespace DataManager.Data
{
    public class GeographicalRepository
    {
        private IGeographicalContext context;
        public GeographicalRepository(IGeographicalContext context)
        {
            this.context = context;
        }   

        public List<CountryDTO> GetAllCountries()
        {
            return context.GetAllCountries().ToList();
        }

        public CountryDTO GetCountry(int id)
        {
            return context.GetCountry(id);
        }

        public List<ContinentDTO> GetAllContinents()
        {
            return context.GetAllContinents().ToList();
        }

        public ContinentDTO GetContinent(int id)
        {
            return context.GetContinent(id);
        }

        public List<Primary_ColorDTO> GetAllColors()
        {
            return context.GetAllColors().ToList();
        }

        public Primary_ColorDTO GetPrimary_Color(int id)
        {
            return context.GetPrimary_Color(id);
        }
    }
}
