using ScoresMaster.Containers;
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
        public ActionResult MyProfile(LoginModel userLogin)
        {
            LoginContainerFE loginContainerFE = new LoginContainerFE();
            ClubContainerFE clubContainerFE = new ClubContainerFE();
            List<string> clubnames = new List<string>();
            List<Club> clubs = clubContainerFE.GetAllClubs();
            for(int i = 1; i <= clubs.Count(); i++)
            {
                clubnames.Add(clubs[i - 1].Name);
            }
            
            userLogin.Unique_id = (string)TempData.Peek("unique_id");
            userLogin = loginContainerFE.GetUserDetails(userLogin.Unique_id);
            ViewBag.first_Name = userLogin.First_Name;
            ViewBag.last_name = userLogin.Last_Name;
            ViewBag.email = userLogin.Email;
            ViewData["Logo"] = userLogin.Favorite_Club.Name+".png";
            ViewBag.Clubs = clubnames;
            
            
            return View("MyProfile"); 
        }
    }
}