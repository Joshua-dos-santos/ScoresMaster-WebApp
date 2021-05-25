using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Interfaces
{
    public interface IRegisterContext
    {
        RegisterDTO StoreUserData(string Fname, string Lname, string email, string password, string birthdate);
        string RandomString();
    }
}
