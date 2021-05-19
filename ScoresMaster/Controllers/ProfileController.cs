using ScoresMaster.Containers;
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
        public ActionResult MyProfile(LoginModel userLogin)
        {

            LeagueContainerFE leagueContainerFE = new LeagueContainerFE();
            List<League> Leagues = new List<League>();
            List<string> leagueNames = new List<string>();
                Leagues = leagueContainerFE.GetAllLeagues();
            for(int i = 1; i <= Leagues.Count(); i++)
            {
                leagueNames.Add(Leagues[i - 1].Name);
            }
            
            userLogin.Unique_id = (string)TempData.Peek("unique_id");
            userLogin = LoginDatabase.GetUserDetails(userLogin);
            ViewBag.first_Name = userLogin.First_Name;
            ViewBag.last_name = userLogin.Last_Name;
            ViewBag.email = userLogin.Email;
            ViewBag.League = leagueNames;
            
            
            return View("MyProfile"); 
        }
    }
}