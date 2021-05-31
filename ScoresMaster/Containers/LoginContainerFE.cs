using DataManager.Business.Containers;
using ScoresMaster.Models;

namespace ScoresMaster.Containers
{
    public class LoginContainerFE
    {
        LoginContainer loginContainer = new LoginContainer();

        public LoginModel CheckLogin(string email, string password)
        {
            var login = loginContainer.CheckLogin(email, password);
            LoginModel loginM = new LoginModel(login);
            return loginM;
        }
        public LoginModel GetUserDetails(string id)
        {
            ClubContainerFE clubContainerFE = new ClubContainerFE();
            var login = loginContainer.GetUserDetails(id);
            LoginModel loginM = new LoginModel(login) { Favorite_Club = clubContainerFE.GetClubByID(login.Favorite_Club.ClubID)};
            return loginM;
        }
        public void UpdateFavoriteClub(int clubId, string userId)
        {
            loginContainer.UpdateFavoriteClub(clubId, userId);
        }
    }
}