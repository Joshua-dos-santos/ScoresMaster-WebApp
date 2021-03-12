﻿using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class RegistrationDatabase
    {
        public bool StoreUserData(string Fname, string Lname, string Email, string Password, string BirthDay)
        {
            string unique_Code = RandomString();
            Database.PAPI_Key = unique_Code;
            string StoreData = "INSERT INTO `user`(`first_name`, `last_name`, `email`, `password`, `last_login`, `birth_date`, `api_key`) VALUES ('" + Fname + "','" + Lname + "','" + Email + "','" + Password + "', '2020-12-02 14:16:47','" + BirthDay + "', '" + unique_Code + "');";
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand commandStoreUser = new MySqlCommand(StoreData, databaseConnection);
            commandStoreUser.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader executeString = commandStoreUser.ExecuteReader();
                databaseConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return false;
            }
        }
        public static string RandomString()
        {
            Random random = new Random();
            string b = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = 20;
            string rnd = "";
            for (int i = 0; i < length; i++)
            {
                int a = random.Next(60);
                rnd = rnd + b.ElementAt(a);
            }
            return rnd;
        }
        public bool StoreUser(RegistrationModel registration)
        {
            if (StoreUserData(registration.First_Name, registration.Last_Name, registration.EMail, registration.Password, registration.Birth_Day))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}