using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoresMaster.Containers;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ScoresMaster
{
    [TestClass]
    public class UnitTestGeographical
    {
        GeographicalContainerFE geographicalContainerFE = new GeographicalContainerFE();

        [TestMethod]
        public void GeographicalContainerFE_GetCountry_GotCountry_GotUganda()
        {
            Country country = new Country { CountryID = 69 };
            Country newCountry = geographicalContainerFE.GetCountry(country.CountryID);
            Assert.IsNotNull(newCountry);
        }

        [TestMethod]
        public void GeographicalContainerFE_GetContinent_GotNull_NothingFound()
        {
            Continent continent = new Continent { ContinentID = 9 };
            Continent newContinent = geographicalContainerFE.GetContinent(continent.ContinentID);
            Assert.AreEqual(null, newContinent.Continents);
        }

        [TestMethod]
        public void GeographicalContainerFE_GetPrimaryColor_GotColor_GotGreen()
        {
            List<Primary_Color> colors = new List<Primary_Color>();
            colors.Add(new Primary_Color { ColorID = 3 });
            colors.Add(new Primary_Color { ColorID = 8 });
            foreach (Primary_Color color in colors)
            {
                Primary_Color Pcolor = geographicalContainerFE.GetPrimary_Color(color.ColorID);
                Assert.IsNotNull(Pcolor.Colors);
            }
        }
    }
}
