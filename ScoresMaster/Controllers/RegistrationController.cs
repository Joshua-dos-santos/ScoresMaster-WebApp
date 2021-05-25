using ScoresMaster.Containers;
using ScoresMaster.Models;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register(RegistrationModel registrationModel)
        {
            RegisterContainerFE registerContainer = new RegisterContainerFE();
            if (!ModelState.IsValid)
            {
                return View("Registration");
            }
            else
            {
                registrationModel = registerContainer.StoreUserData(registrationModel.First_Name, registrationModel.Last_Name, registrationModel.EMail, registrationModel.Password, registrationModel.Birth_Day);
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