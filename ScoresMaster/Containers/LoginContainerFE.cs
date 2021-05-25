using DataManager.Business.Containers;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Containers
{
    public class LoginContainerFE
    {
        LoginContainer loginContainer = new LoginContainer();

        public LoginModel CheckLogin(string email, string password)
        {
            var login = loginContainer.CheckLogin(email, password);
            LoginModel loginM = new LoginModel(login);
            return loginM;
        }
        public LoginModel GetUserDetails(string id)
        {
            var login = loginContainer.GetUserDetails(id);
            LoginModel loginM = new LoginModel(login);
            return loginM;
        }
    }
}