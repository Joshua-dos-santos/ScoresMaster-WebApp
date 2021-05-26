using DataManager.Business.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoresMaster.Containers;
using ScoresMaster.Models;
using System.Collections.Generic;

namespace UnitTest_ScoresMaster
{
    [TestClass]
    public class UnitTestLogin
    {
        LoginContainerFE loginContainer = new LoginContainerFE();


        [TestMethod]
        public void LoginContainerFE_CheckLogin_IsNull_FalseLogin() 
        {
            LoginModel login = new LoginModel { First_Name = "Joost", Last_Name = "Koe", Email = "joost@test.nl", Password = "Jtest" };
            LoginModel newlogin = loginContainer.CheckLogin(login.Email, login.Password);
            Assert.AreEqual(null, newlogin.Unique_id);
        }
        [TestMethod]
        public void LoginContainerFE_GetUserDetails_True_GotDetails()
        {
            var result = false;
            LoginModel login = new LoginModel { First_Name = "joshua", Last_Name = "mota", Email = "joshua@mota.nl", Password = "test", Unique_id = "gPkxWqOd57gcXtRHsK7E" };
            LoginModel newLogin = loginContainer.GetUserDetails(login.Unique_id);
            if(newLogin == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
