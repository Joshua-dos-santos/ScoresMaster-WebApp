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
        public ActionResult Registrate()
        {
            return View("Registration");
        }
    }
}