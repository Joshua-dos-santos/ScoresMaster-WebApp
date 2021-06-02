using Newtonsoft.Json;
using ScoresMaster.Containers;
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
        PlayerContainerFE playerContainerFE = new PlayerContainerFE();

        public ActionResult Home_team(Club club, Match match)
        {
            club.Name = match.Home_Team;
            ViewData["Logo"] = match.Home_Team + ".png";
            ViewBag.Home_Team = match.Home_Team;
            club = clubContainerFE.GetClubByName(club.Name);
            List<Player> playerList = playerContainerFE.GetAllPlayersByClub(club.ClubID);
            return View("ViewHomeSquad", playerList);
        }

        public ActionResult Away_team(Club club, Match match)
        {
            club.Name = match.Away_Team;
            ViewData["Logo"] = match.Away_Team + ".png";
            ViewBag.Away_Team = match.Away_Team;
            club = clubContainerFE.GetClubByName(club.Name);
            List<Player> playerList = playerContainerFE.GetAllPlayersByClub(club.ClubID);
            return View("ViewAwaySquad", playerList);
        }

        public ActionResult CountrySquad(Country country, Player player)
        {
            //Player newPlayer = playerContainerFE.GetPlayer(player.PlayerID);
            //country = newPlayer.Nationality;
            ViewBag.Country = country.Name;
            var players = playerContainerFE.GetAllPlayersByCountry(country.CountryID).OrderBy(c => c.Position.unique_id).ToList();

            return View("CountrySquad", players);
        }

        public ActionResult CountryList()
        {
            GeographicalContainerFE geographicalContainerFE = new GeographicalContainerFE();
            List<Country> countries = new List<Country>();
            countries = geographicalContainerFE.GetAllCountries();
            return View("AllCountries", countries);
        }
    }
}