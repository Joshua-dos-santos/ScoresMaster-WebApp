﻿using ScoresMaster.DatabaseConnections;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoresMaster.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult MyProfile(LoginModel userLogin, League league)
        {
            LeagueDatabase leagueDatabase = new LeagueDatabase();
            LoginDatabase loginDatabase = new LoginDatabase();
            List<string> Leagues = new List<string>();
            for (int i = 1; i <= 33; i++)
            {
                Leagues.Add(leagueDatabase.GetLeagues(i));
            }
            string api_key = loginDatabase.CheckLogin(userLogin.Email, userLogin.Password);
            string first_Name = loginDatabase.GetUserName(api_key);
            ViewBag.Name = first_Name;
            ViewBag.League = Leagues;
            return View("MyProfile", league); 
        }
    }
}