﻿using MySql.Data.MySqlClient;
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
                    string outputs = executeString.GetString(0);
                    if(outputs == "")
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
        public string FindByUser(LoginModel userLogin)
        {
            string Output = CheckLogin(userLogin.Email, userLogin.Password);
            if (!Output.Equals(""))
            {
                return Output;
            }
            return null;
        }

       

        public string GetUserDetails(string Detail, string unique_Code)
        {
            string getDetails = "SELECT `"+Detail+"` FROM `user` where `api_key`= '" + unique_Code + "';";
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand commandGetDetails = new MySqlCommand(getDetails, databaseConnection);
            commandGetDetails.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader executeString = commandGetDetails.ExecuteReader();
                while (executeString.Read())
                {
                    string userDetail = executeString.GetString(0);
                    if (userDetail == "")
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
    }
}