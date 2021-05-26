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
    public class UnitTestMatch
    {
        MatchContainerFE matchContainerFE = new MatchContainerFE();

        [TestMethod]
        public void MatchContainerFE_GetAllMatches_IsNotNull_GotMatches()
        {
            List<Match> matches = new List<Match>();
            matches = matchContainerFE.GetAllMatches(352);
            Assert.AreNotEqual(0, matches.Count);
        }
    }
}
