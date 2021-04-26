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

        public List<CountryDTO> GetAllCountries(CountryDTO country)
        {
            return context.GetAllCountries(country).ToList();
        }

        public CountryDTO GetCountry(int id, CountryDTO country)
        {
            return context.GetCountry(id, country);
        }

        public List<ContinentDTO> GetAllContinents(ContinentDTO continent)
        {
            return context.GetAllContinents(continent).ToList();
        }

        public ContinentDTO GetContinent(int id, ContinentDTO continent)
        {
            return context.GetContinent(id, continent);
        }

        public List<Primary_ColorDTO> GetAllColors(Primary_ColorDTO primary_Color)
        {
            return context.GetAllColors(primary_Color).ToList();
        }

        public Primary_ColorDTO GetPrimary_Color(int id, Primary_ColorDTO primary_Color)
        {
            return context.GetPrimary_Color(id, primary_Color);
        }
    }
}
