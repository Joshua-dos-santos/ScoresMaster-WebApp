using Newtonsoft.Json;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class SquadController : Controller
    {
        public ActionResult Index(int matchnumber)
        {

            ViewBag.MatchNumber = matchnumber;
            return View("ViewSquad");
        }
    }
}