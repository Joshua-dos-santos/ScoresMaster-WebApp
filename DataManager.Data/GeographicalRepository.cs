using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    class GeographicalRepository
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
    }
}
