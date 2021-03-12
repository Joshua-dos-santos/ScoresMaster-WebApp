using ScoresMaster.DatabaseConnections;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Registrate(RegistrationModel registrationModel)
        {
            RegistrationDatabase registrationDatabase = new RegistrationDatabase();
            Boolean Registration = registrationDatabase.StoreUser(registrationModel);
            if (!Registration)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View("Registration");
            }
        }
    }
}