using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    class CountryDTO
    {
        public CountryDTO(int id, string name)
        {
            CountryID = id;
            Name = name;
        }

        public int CountryID { get; set; }
        public string Name { get; set; }
        public ContinentDTO continent { get; set; }
        public Primary_ColorDTO primary_Color { get; set; }
    }
}
