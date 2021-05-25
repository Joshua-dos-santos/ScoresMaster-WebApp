using DataManager.Business.DAO;
using DataManager.Data.Logic;
using DataManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.Containers
{
    public class RegisterContainer
    {
        RegisterDatabaseContext context = new RegisterDatabaseContext();

        public RegisterDAO StoreUserData(string Fname, string Lname, string email, string password, string birthdate)
        {
            RegisterRepository repo = new RegisterRepository(context);
            var registration = repo.StoreUserData(Fname, Lname, email, password, birthdate);
            RegisterDAO register = new RegisterDAO(registration);
            return register;
        }
    }
}
