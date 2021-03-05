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
        public string CheckLogin(string Uname, string Password)
        {
            string checkLogin = "SELECT `api_key` FROM `user` WHERE `email` = '" + Uname + "' AND `password`= '" + Password + "';";
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand commandCheckLogin = new MySqlCommand(checkLogin, databaseConnection);
            commandCheckLogin.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader executeString = commandCheckLogin.ExecuteReader();
                while (executeString.Read())
                {
                    string output = executeString.GetString(0);
                    if(output == "")
                    {
                        return "";
                    }
                    else
                    {
                        return executeString.GetString(0);
                    }
                }
                databaseConnection.Close();
                return "";
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return "";
            }
        }
        internal string FindByUser(LoginModel userLogin)
        {
            string Output = CheckLogin(userLogin.Email, userLogin.Password);
            if (!Output.Equals(""))
            {
                return Output;
            }
            else
            {
                return "";
            }
        }

        public string authenticate(LoginModel userLogin)
        {
            return FindByUser(userLogin);
        }
    }
}