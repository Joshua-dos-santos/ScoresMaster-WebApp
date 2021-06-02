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
    public class UnitTestPlayer
    {
        PlayerContainerFE playerContainerFE = new PlayerContainerFE();


        [TestMethod]
        public void PlayerContainerFE_GetAllPlayers_False_NoClubFound()
        {
            var result = true;
            List<Player> players = new List<Player>();
            players = playerContainerFE.GetAllPlayersByClub(0);
            if (players.Count == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void PlayerContainerFE_GetPosition_IsNotNull_GotLW()
        {
            Position position = new Position { unique_id = 13 };
            Position newPosition = playerContainerFE.GetPosition(position.unique_id);
            Assert.AreEqual("LW", newPosition.Positions);
        }
    }
}
