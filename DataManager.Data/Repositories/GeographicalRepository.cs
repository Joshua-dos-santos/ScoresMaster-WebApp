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

        public CountryDTO GetCountry(int id)
        {
            return context.GetCountry(id);
        }

        public ContinentDTO GetContinent(int id)
        {
            return context.GetContinent(id);
        }

        public Primary_ColorDTO GetPrimary_Color(int id)
        {
            return context.GetPrimary_Color(id);
        }
    }
}
