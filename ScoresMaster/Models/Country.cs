using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public Continent continent { get; set; }
        public Primary_Color primary_Color { get; set; }
    }
}