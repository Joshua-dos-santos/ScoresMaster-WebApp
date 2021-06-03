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
            List<Match> matchesBundesliga = matchContainer.GetAllMatches(496);
            List<Match> matchesEredivisie = matchContainer.GetAllMatches(706);
            List<Match> matchesLigaNOS = matchContainer.GetAllMatches(762);
            List<Match> matchesLigue1 = matchContainer.GetAllMatches(455);
            var allMatches = matchesPL.Concat(matchesSerieA).Concat(matchesBundesliga).Concat(matchesEredivisie).Concat(matchesLigaNOS).Concat(matchesLigue1);
            var Matches = allMatches.OrderBy(c => c.Match_Start).ToList();
            return View("", Matches);
        }
    }
}