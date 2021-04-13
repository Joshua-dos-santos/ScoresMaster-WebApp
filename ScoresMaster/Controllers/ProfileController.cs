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
            

            List<string> Leagues = new List<string>();
            for (int i = 1; i <= 33; i++)
            {
                league = LeagueDatabase.GetLeagues(i, league);
                Leagues.Add(league.Name);
            }
            
            userLogin.Unique_id = (string)TempData.Peek("unique_id");
            userLogin = LoginDatabase.GetUserDetails(userLogin);
            ViewBag.first_Name = userLogin.First_Name;
            ViewBag.last_name = userLogin.Last_Name;
            ViewBag.email = userLogin.Email;
            ViewBag.League = Leagues;
            
            
            return View("MyProfile", league); 
        }
    }
}