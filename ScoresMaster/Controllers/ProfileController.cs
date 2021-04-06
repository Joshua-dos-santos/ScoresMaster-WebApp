using ScoresMaster.DatabaseConnections;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult MyProfile(LoginModel userLogin, League league)
        {
            LeagueDatabase leagueDatabase = new LeagueDatabase();
            LoginDatabase loginDatabase = new LoginDatabase();

            List<string> Leagues = new List<string>();
            for (int i = 1; i <= 33; i++)
            {
                Leagues.Add(leagueDatabase.GetLeagues(i));
            }
            
            userLogin.unique_id = (string)TempData.Peek("unique_id");
            ViewBag.first_Name = loginDatabase.GetUserDetails("first_name",userLogin.unique_id);
            ViewBag.last_name = loginDatabase.GetUserDetails("last_name",userLogin.unique_id);
            ViewBag.email = loginDatabase.GetUserDetails("email",userLogin.unique_id);
            ViewBag.password = loginDatabase.GetUserDetails("password",userLogin.unique_id);
            ViewBag.birth_day = loginDatabase.GetUserDetails("birth_date",userLogin.unique_id);
            ViewBag.League = Leagues;
            
            
            return View("MyProfile", league); 
        }
    }
}