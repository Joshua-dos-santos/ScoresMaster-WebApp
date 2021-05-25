using ScoresMaster.Containers;
using ScoresMaster.Models;
using System.Web.Mvc;
namespace ScoresMaster.Controllers
{
    public class LoginController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View("Login");
        //}
        // GET: Login
        public ActionResult LoginAction(LoginModel loginModel)
        {
            LoginContainerFE loginContainerFE = new LoginContainerFE();
            if (ModelState.IsValid)
            {
                loginModel = loginContainerFE.CheckLogin(loginModel.Email, loginModel.Password);
                if (loginModel.Unique_id != "" && loginModel.Unique_id != null)
                {
                    TempData["unique_id"] = loginModel.Unique_id;
                    return RedirectToAction("MyProfile", "Profile");
                }
                else
                {
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }
        }
    }
}