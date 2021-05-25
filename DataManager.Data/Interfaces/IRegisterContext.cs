using DataManager.Data.DTO;

namespace DataManager.Data.Interfaces
{
    public interface IRegisterContext
    {
        RegisterDTO StoreUserData(string Fname, string Lname, string email, string password, string birthdate);
        string RandomString();
    }
}
