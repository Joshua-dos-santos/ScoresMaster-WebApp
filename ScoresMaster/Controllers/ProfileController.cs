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
        public ActionResult ShowMyProfile(LoginModel userLogin)
        {
            int i;
            LoginContainerFE loginContainerFE = new LoginContainerFE();
            ClubContainerFE clubContainerFE = new ClubContainerFE();
            List<string> clubnames = new List<string>();
            List<Club> clubs = clubContainerFE.GetAllClubs();
            for(i = 1; i <= clubs.Count(); i++)
            { 
                clubnames.Add(clubs[i - 1].Name);
            }
            userLogin.Unique_id = (string)TempData.Peek("unique_id");
            userLogin = loginContainerFE.GetUserDetails(userLogin.Unique_id);
            ViewBag.first_Name = userLogin.First_Name;
            ViewBag.last_name = userLogin.Last_Name;
            ViewBag.email = userLogin.Email;
            ViewBag.FavoriteClub = userLogin.Favorite_Club;
            ViewData["Logo"] = userLogin.Favorite_Club.Name+".png";
            var clublist = clubs;
            return View("MyProfile", clublist); 
        }
        public ActionResult UpdateClub(LoginModel loginModel, Club club)
        {
            loginModel.Favorite_Club = club;
            LoginContainerFE loginContainerFE = new LoginContainerFE();
            loginModel.Unique_id = (string)TempData.Peek("unique_id");
            loginContainerFE.UpdateFavoriteClub(loginModel.Favorite_Club.ClubID, loginModel.Unique_id);
            loginModel = loginContainerFE.GetUserDetails(loginModel.Unique_id);
            return RedirectToAction("ShowMyProfile", loginModel);
        }
    }
}