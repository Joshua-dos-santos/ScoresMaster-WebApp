using ScoresMaster.Containers;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class LeagueController : Controller
    {
        // GET: League
        public ActionResult Details()
        {
            StandingsContainerFE standingsContainerFE = new StandingsContainerFE();
            ViewBag.StandingsPL = standingsContainerFE.GetAllStandings(352, 19);
            ViewBag.standingsSerieA = standingsContainerFE.GetAllStandings(619, 19);
            ViewBag.standingsEredivisie = standingsContainerFE.GetAllStandings(706, 17);
            ViewBag.standingsLigaNOS = standingsContainerFE.GetAllStandings(762, 17);
            ViewBag.standingsLigue1 = standingsContainerFE.GetAllStandings(455, 19);
            ViewBag.standingsBundesliga = standingsContainerFE.GetAllStandings(496, 17);

            return View("LeagueInfo");
        }
    }
}