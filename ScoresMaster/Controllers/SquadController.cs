using Newtonsoft.Json;
using ScoresMaster.DatabaseConnections;
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
        public ActionResult Home_team(Club club, Match match, Player player)
        {
            club = ClubDatabase.GetHome_Team(club, match);
            List<Player> playerList = PlayerDatabase.GetPlayers(club, player);
            

            return View("ViewHomeSquad", playerList);
        }

        public ActionResult Away_team(Club club, Match match, Player player)
        {
            ViewBag.Away_Team = match.Away_Team;
            List<Player> playerList = PlayerDatabase.GetPlayers(club, player);
            return View("ViewAwaySquad", playerList);
        }
    }
}