using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data
{
    public class CountryDTO
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ContinentDTO continent { get; set; }
        public Primary_ColorDTO primary_Color { get; set; }
    }
}
