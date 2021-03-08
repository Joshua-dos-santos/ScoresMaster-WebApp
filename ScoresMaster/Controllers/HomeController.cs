using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LeagueDatabase leagueDatabase = new LeagueDatabase();
            List<string> Leagues = new List<string>();
            for (int i = 1; i <= 33; i++)
            {
                Leagues.Add(leagueDatabase.GetLeagues(i));
            }
            ViewBag.League = Leagues;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}