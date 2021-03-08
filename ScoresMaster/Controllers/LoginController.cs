using ScoresMaster.DatabaseConnections;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(LoginModel userLogin)
        {
            LoginDatabase loginDatabase = new LoginDatabase();
            string apiKey = loginDatabase.authenticate(userLogin);
            if (apiKey == "")
            {
                return View("Login");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
    }
}