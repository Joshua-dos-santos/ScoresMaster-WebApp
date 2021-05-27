using ScoresMaster.Containers;
using Newtonsoft.Json;
using ScoresMaster.Models;
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
            MatchContainerFE matchContainer = new MatchContainerFE();
            List<Match> matchesPL = matchContainer.GetAllMatches(352);
            List<Match> matchesSerieA = matchContainer.GetAllMatches(619);
            var allMatches = matchesPL.Concat(matchesSerieA);
            return View("", allMatches);
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