using DataManager.Business.DAO;
using DataManager.Data.Logic;
using DataManager.Data.Repositories;

namespace DataManager.Business.Containers
{
    public class LoginContainer
    {
        LoginDatabaseContext context = new LoginDatabaseContext();
        public LoginDAO CheckLogin(string email, string password)
        {
            LoginRepository repo = new LoginRepository(context);
            var login = repo.CheckLogin(email, password);
            LoginDAO loginDAO = new LoginDAO(login);
            return loginDAO;
        }

        public LoginDAO GetUserDetails(string id)
        {
            LoginRepository repo = new LoginRepository(context);
            ClubContainer clubContainer = new ClubContainer();
            var login = repo.GetUserDetails(id);
            LoginDAO loginDAO = new LoginDAO(login) {Favorite_Club =  clubContainer.GetClubByID(login.Favorite_Club.ClubID)};
            return loginDAO;
        }
    }
}
