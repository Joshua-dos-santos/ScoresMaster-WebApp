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
            dynamic PLData = JsonConvert.DeserializeObject(Api.GetMatches("352"));
            dynamic SerieAData = JsonConvert.DeserializeObject(Api.GetMatches("619"));
            ViewBag.Prem = PLData.data;
            ViewBag.SerieA = SerieAData.data;

            List<Match> matchList = new List<Match>();

            for (int i = 0; i <= 9; i++)
            {
                Match match = new Match();
                match.Home_Team = ViewBag.Prem[i].home_team.name;
                match.Match_Start = ViewBag.Prem[i].match_start;
                match.Away_Team = ViewBag.Prem[i].away_team.name;
                matchList.Add(match);
            }

            return View("", matchList);
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