using DataManager.Business.Containers;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Containers
{
    public class RegisterContainerFE
    {
        RegisterContainer registerContainer = new RegisterContainer();

        public RegistrationModel StoreUserData(string Fname, string Lname, string email, string password, string birthdate)
        {
            var Register = registerContainer.StoreUserData(Fname, Lname, email, password, birthdate);
            RegistrationModel registration = new RegistrationModel(Register);
            return registration;
        }
    }
}