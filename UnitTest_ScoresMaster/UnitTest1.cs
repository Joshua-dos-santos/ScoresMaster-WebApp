using DataManager.Business.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoresMaster.Containers;
using ScoresMaster.Models;

namespace UnitTest_ScoresMaster
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginContainerFE_CheckLogin_IsNull_FalseLogin() 
        {
            LoginContainerFE loginContainer = new LoginContainerFE();
            LoginModel login = new LoginModel { First_Name = "Joost", Last_Name = "Koe", Email = "joost@test.nl", Password = "Jtest" };
            login = loginContainer.CheckLogin(login.Email, login.Password);
            Assert.AreEqual(null, login.Unique_id);
        }

        [TestMethod]
        public void ClubContainerFE_GetClub_GotClub_GotManchesterUnited()
        {
            ClubContainerFE clubContainerFE = new ClubContainerFE();
            Club club = new Club { Name = "Manchester United" };
            Club newClub = clubContainerFE.GetClub(club.Name);
            Assert.AreEqual(152, newClub.ClubID);
        }
    }
}
