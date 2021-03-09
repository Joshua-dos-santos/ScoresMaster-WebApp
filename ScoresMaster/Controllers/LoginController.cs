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
            LoginDatabase loginDatabase = new LoginDatabase();
            string apiKey = loginDatabase.authenticate(userLogin);
            if (!apiKey.Equals(""))
            {
                return View("~/Views/Profile/MyProfile.cshtml", league);
            }
            else
            {
                return View("~/Views/Login/Login.cshtml");
            }
        }
    }
}