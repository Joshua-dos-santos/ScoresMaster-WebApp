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
        public ActionResult Index(Match match)
        { 
            dynamic PLData = JsonConvert.DeserializeObject(Api.GetMatches("352"));
            dynamic SerieAData = JsonConvert.DeserializeObject(Api.GetMatches("619"));
            ViewBag.Prem = PLData.data;
            ViewBag.SerieA = SerieAData.data;
            return View("", match);
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