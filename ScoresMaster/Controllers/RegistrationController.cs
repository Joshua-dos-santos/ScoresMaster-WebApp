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
        public ActionResult Register(RegistrationModel RegistrationModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Registration");
            }
            else
            {
                RegistrationDatabase registrationDatabase = new RegistrationDatabase();
                Boolean Registration = registrationDatabase.StoreUser(RegistrationModel);
                if (Registration)
                {
                    return RedirectToAction("", "Home");
                }
                else
                {
                    return View("Registration");
                }
            }
        }
    }
}