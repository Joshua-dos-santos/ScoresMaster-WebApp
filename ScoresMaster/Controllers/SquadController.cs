using Newtonsoft.Json;
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
    public class SquadController : Controller
    {
            ClubContainerFE clubContainerFE = new ClubContainerFE();
        PlayerContainerFE PlayerContainerFE = new PlayerContainerFE();

        public ActionResult Home_team(Club club, Match match, Position position)
        {
            club.Name = match.Home_Team;
            ViewBag.Home_Team = match.Home_Team;
            club = clubContainerFE.GetClub(club.Name);
            int id = club.ClubID;
            List<Player> playerList = PlayerContainerFE.GetAllPlayers(id);
            

            return View("ViewHomeSquad", playerList);
        }

        public ActionResult Away_team(Club club, Match match, Position position)
        {
            club.Name = match.Away_Team;
            ViewBag.Away_Team = match.Away_Team;
            club = clubContainerFE.GetClub(club.Name);
            List<Player> playerList = PlayerDatabase.GetPlayers(club, position);
            return View("ViewAwaySquad", playerList);
        }
    }
}