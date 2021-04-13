using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class LoginDatabase
    {
        public static LoginModel CheckLogin(LoginModel loginModel)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getUserData = new MySqlCommand("SELECT `api_key` FROM user WHERE email=@val1 AND password=@val2", databaseConnection);
            getUserData.Parameters.AddWithValue("@val1", loginModel.Email);
            getUserData.Parameters.AddWithValue("@val2", loginModel.Password);
            try
            {
                databaseConnection.Open();
                getUserData.Prepare();
                var executeString = getUserData.ExecuteReader();
                while (executeString.Read())
                {
                    loginModel.Unique_id = executeString.GetString(0); 
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return loginModel;
        }




        public static LoginModel GetUserDetails(LoginModel loginModel)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getUserDetails = new MySqlCommand("SELECT * FROM `user` WHERE `api_key`=@val2", databaseConnection);
            getUserDetails.Parameters.AddWithValue("@val2", loginModel.Unique_id);
            try
            {
                databaseConnection.Open();
                getUserDetails.Prepare();
                var executeString = getUserDetails.ExecuteReader();
                while (executeString.Read())
                {
                    loginModel.First_Name = executeString.GetString(1);
                    loginModel.Last_Name = executeString.GetString(2);
                    loginModel.Email = executeString.GetString(3);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return loginModel;
        }
    }
}