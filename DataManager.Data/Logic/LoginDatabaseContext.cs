using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using MySql.Data.MySqlClient;
using System;

namespace DataManager.Data.Logic
{
    public class LoginDatabaseContext : ILoginContext
    {
            ClubDTO clubDTO = new ClubDTO();
            LoginDTO login = new LoginDTO();
        public LoginDTO CheckLogin(string email, string password)
        {
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getUserData = new MySqlCommand("SELECT `api_key` FROM user WHERE email=@val1 AND password=@val2", databaseConnection);
            getUserData.Parameters.AddWithValue("@val1", email);
            getUserData.Parameters.AddWithValue("@val2", password);
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

        public LoginDTO GetUserDetails(string id)
        {
            ClubDatabaseContext clubDatabaseContext = new ClubDatabaseContext();
            ClubDTO clubDTO = new ClubDTO();
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand getUserDetails = new MySqlCommand("SELECT * FROM `user` WHERE `api_key`=@val2", databaseConnection);
            getUserDetails.Parameters.AddWithValue("@val2", id);
            try
            {
                databaseConnection.Open();
                getUserDetails.Prepare();
                var executeString = getUserDetails.ExecuteReader();
                while (executeString.Read())
                {
                    login.First_Name = executeString.GetString(1);
                    login.Last_Name = executeString.GetString(2);
                    login.Email = executeString.GetString(3);
                    login.Password = executeString.GetString(4);
                    clubDTO.ClubID = executeString.GetInt32(8);
                    login.Favorite_Club = clubDatabaseContext.GetClubByID(clubDTO.ClubID); 
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return login;
        }
    }
    }

