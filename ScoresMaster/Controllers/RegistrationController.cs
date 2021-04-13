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
        public ActionResult Register(RegistrationModel registrationModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Registration");
            }
            else
            {
                registrationModel = RegistrationDatabase.StoreUserData(registrationModel);
                if (registrationModel != null)
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