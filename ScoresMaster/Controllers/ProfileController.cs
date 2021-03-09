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
        public ActionResult MyProfile()
        {
            LeagueDatabase leagueDatabase = new LeagueDatabase();
            List<string> Leagues = new List<string>();
            for (int i = 1; i <= 33; i++)
            {
                Leagues.Add(leagueDatabase.GetLeagues(i));
            }
            ViewBag.League = Leagues;
            return View("MyProfile"); 
        }
    }
}