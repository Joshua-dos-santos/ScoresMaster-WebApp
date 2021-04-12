using ScoresMaster.DatabaseConnections;
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
        public ActionResult LoginAction(LoginModel userLogin)
        {
            if (!ModelState.IsValid)
            {
                LoginDatabase loginDatabase = new LoginDatabase();
                userLogin.Unique_id = loginDatabase.FindByUser(userLogin);
                if (userLogin.Unique_id != "" && userLogin.Unique_id != null)
                {
                    TempData["unique_id"] = userLogin.Unique_id;
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