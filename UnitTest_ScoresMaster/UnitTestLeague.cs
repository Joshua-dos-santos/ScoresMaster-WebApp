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
    public class UnitTestLeague
    {
        LeagueContainerFE leagueContainerFE = new LeagueContainerFE();

        [TestMethod]
        public void LeagueContainerFE_GetAllLeagues_True_GotLeagues()
        {
            var result = false;
            List<League> leagues = new List<League>();
            leagues = leagueContainerFE.GetAllLeagues();
            if (leagues == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LeagueContainerFE_GetLeague_Eredivisie_GotLeague()
        {
            League league = new League { LeagueID = 14 };
            League newLeague = leagueContainerFE.GetLeague(league.LeagueID);
            Assert.AreEqual("Eredivisie", newLeague.Name);
        }
    }
}
