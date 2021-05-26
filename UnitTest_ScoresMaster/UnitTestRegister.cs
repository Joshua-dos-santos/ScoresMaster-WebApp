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
    public class UnitTestRegister
    {
        RegisterContainerFE registerContainerFE = new RegisterContainerFE();


        [TestMethod]
        public void RegisterContainerFE_StoreUserDetails_True_InsertedDetails()
        {
            RegistrationModel registration = new RegistrationModel { First_Name = "Joost", Last_Name = "Koe", EMail = "joostK@test.nl", Password = "password", Birth_Day = "2001-09-31" };
            RegistrationModel newRegistration = registerContainerFE.StoreUserData(registration.First_Name, registration.Last_Name, registration.EMail, registration.Password, registration.Birth_Day);
            Assert.IsNotNull(newRegistration);
        }
    }
}
