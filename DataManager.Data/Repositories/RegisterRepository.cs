using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Repositories
{
    public class RegisterRepository
    {
        private IRegisterContext context;

        public RegisterRepository(RegisterDatabaseContext context)
        {
            this.context = context;
        }

        public RegisterDTO StoreUserData(string Fname, string Lname, string email, string password, string birthdate)
        {
            return context.StoreUserData(Fname, Lname, email, password, birthdate);
        }

        public string RandomString()
        {
            return context.RandomString();
        }
    }
}
