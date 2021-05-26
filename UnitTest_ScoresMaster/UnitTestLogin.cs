using DataManager.Business.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoresMaster.Containers;
using ScoresMaster.Models;
using System.Collections.Generic;

namespace UnitTest_ScoresMaster
{
    [TestClass]
    public class UnitTestLogin
    {
        ClubContainerFE clubContainerFE = new ClubContainerFE();
        GeographicalContainerFE geographicalContainerFE = new GeographicalContainerFE();
        LoginContainerFE loginContainer = new LoginContainerFE();
        LeagueContainerFE leagueContainerFE = new LeagueContainerFE();
        PlayerContainerFE playerContainerFE = new PlayerContainerFE();
        MatchContainerFE matchContainerFE = new MatchContainerFE();
        RegisterContainerFE registerContainerFE = new RegisterContainerFE();


        [TestMethod]
        public void LoginContainerFE_CheckLogin_IsNull_FalseLogin() 
        {
            LoginModel login = new LoginModel { First_Name = "Joost", Last_Name = "Koe", Email = "joost@test.nl", Password = "Jtest" };
            LoginModel newlogin = loginContainer.CheckLogin(login.Email, login.Password);
            Assert.AreEqual(null, newlogin.Unique_id);
        }
        [TestMethod]
        public void LoginContainerFE_GetUserDetails_True_GotDetails()
        {
            var result = false;
            LoginModel login = new LoginModel { First_Name = "joshua", Last_Name = "mota", Email = "joshua@mota.nl", Password = "test", Unique_id = "gPkxWqOd57gcXtRHsK7E" };
            LoginModel newLogin = loginContainer.GetUserDetails(login.Unique_id);
            if(newLogin == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ClubContainerFE_GetClub_GotClub_GotManchesterUnited()
        {
            
            Club club = new Club { Name = "Manchester United" };
            Club newClub = clubContainerFE.GetClub(club.Name);
            Assert.AreEqual(152, newClub.ClubID);
        }

        [TestMethod]
        public void GeographicalContainerFE_GetCountry_GotCountry_GotUganda()
        {
            Country country = new Country { CountryID = 69};
            Country newCountry = geographicalContainerFE.GetCountry(country.CountryID);
            Assert.IsNotNull(newCountry);
        }

        [TestMethod]
        public void GeographicalContainerFE_GetContinent_GotNull_NothingFound()
        {
            Continent continent = new Continent {ContinentID = 9};
            Continent newContinent = geographicalContainerFE.GetContinent(continent.ContinentID);
            Assert.AreEqual(null, newContinent.Continents);
        }

        [TestMethod]
        public void GeographicalContainerFE_GetPrimaryColor_GotColor_GotGreen()
        {
            List<Primary_Color> colors = new List<Primary_Color>();
            colors.Add(new Primary_Color { ColorID = 3 });
            colors.Add(new Primary_Color { ColorID = 8 });
            foreach(Primary_Color color in colors)
            {
                Primary_Color Pcolor = geographicalContainerFE.GetPrimary_Color(color.ColorID);
                Assert.IsNotNull(Pcolor.Colors);
            }
        }
        [TestMethod]
        public void LeagueContainerFE_GetAllLeagues_True_GotLeagues()
        {
            var result = false;
            List<League> leagues = new List<League>();
            leagues = leagueContainerFE.GetAllLeagues();
            if(leagues == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LeagueContainerFE_GetLeague_Eredivisie_GotLeague()
        {
            League league = new League{ LeagueID = 14 };
            League newLeague = leagueContainerFE.GetLeague(league.LeagueID);
            Assert.AreEqual("Eredivisie", newLeague.Name);
        }
        [TestMethod]
        public void PlayerContainerFE_GetAllPlayers_False_NoClubFound()
        {
            var result = true;
            List<Player> players = new List<Player>();
            players = playerContainerFE.GetAllPlayers(0);
            if (players.Count == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void PlayerContainerFE_GetPosition_IsNotNull_GotLW()
        {
            Position position = new Position { unique_id = 13 };
            Position newPosition = playerContainerFE.GetPosition(position.unique_id);
            Assert.AreEqual("LW", newPosition.Positions);
        }
        [TestMethod]
        public void MatchContainerFE_GetAllMatches_IsNotNull_GotMatches()
        {
            List<Match> matches = new List<Match>();
            matches = matchContainerFE.GetAllMatches(352);
            Assert.AreNotEqual(0, matches.Count);
        }
        [TestMethod]
        public void RegisterContainerFE_StoreUserDetails_True_InsertedDetails()
        {
            RegistrationModel registration = new RegistrationModel { First_Name = "Joost", Last_Name = "Koe", EMail = "joostK@test.nl", Password = "password", Birth_Day = "2001-09-31" };
            RegistrationModel newRegistration = registerContainerFE.StoreUserData(registration.First_Name, registration.Last_Name, registration.EMail, registration.Password, registration.Birth_Day);
            Assert.IsNotNull(newRegistration);
        }
    }
}
