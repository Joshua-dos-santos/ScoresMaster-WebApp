using ScoresMaster.DatabaseConnections;
using ScoresMaster.Models;
using System.Web.Mvc;
namespace ScoresMaster.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(LoginModel userLogin, League league)
        {
            if (ModelState.IsValid)
            {
                LoginDatabase loginDatabase = new LoginDatabase();
                userLogin.unique_id = loginDatabase.FindByUser(userLogin);
                if (userLogin.unique_id != "0" && userLogin.unique_id != null)
                {
                    TempData["unique_id"] = userLogin.unique_id;
                    return RedirectToAction("", "Home");
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