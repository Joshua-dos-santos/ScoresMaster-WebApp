using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    class GeographicalDatabaseContext : IGeographicalContext
    {
        public IEnumerable<CountryDTO> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public CountryDTO GetCountry(int id)
        {
            throw new NotImplementedException();
        }
    }
}
