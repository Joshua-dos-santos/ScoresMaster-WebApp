using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Logic
{
    public class LoginDatabaseContext : ILoginContext
    {
        public LoginDTO CheckLogin()
        {
            LoginDTO login = new LoginDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getUserData = new MySqlCommand("SELECT `api_key` FROM user WHERE email=@val1 AND password=@val2", databaseConnection);
            getUserData.Parameters.AddWithValue("@val1", login.Email);
            getUserData.Parameters.AddWithValue("@val2", login.Password);
            try
            {
                databaseConnection.Open();
                getUserData.Prepare();
                var executeString = getUserData.ExecuteReader();
                while (executeString.Read())
                {
                    login.Unique_id = executeString.GetString(0);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return login;
        }

        public LoginDTO GetUserDetails()
        {
            throw new NotImplementedException();
        }
    }
}
