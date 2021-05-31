using DataManager.Data.DTO;

namespace DataManager.Data.Interfaces
{
    public interface ILoginContext
    {
        LoginDTO CheckLogin(string email, string password);
        LoginDTO GetUserDetails(string id);
        void UpdateFavoriteClub(int clubId, string userId);
    }
}
