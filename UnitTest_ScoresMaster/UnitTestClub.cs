﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class UnitTestClub
    {
        ClubContainerFE clubContainerFE = new ClubContainerFE();

        [TestMethod]
        public void ClubContainerFE_GetClubByName_GotClub_GotManchesterUnited()
        {
            Club club = new Club { Name = "Manchester United" };
            Club newClub = clubContainerFE.GetClubByName(club.Name);
            Assert.AreEqual(152, newClub.ClubID);
        }
        [TestMethod]
        public void ClubContainerFE_GetClubByID_GotNothing_GotNull()
        {
            Club club = new Club { ClubID = 679 };
            Club newClub = clubContainerFE.GetClubByID(club.ClubID);
            Assert.IsNull(newClub.Name);
        }
    }
}
