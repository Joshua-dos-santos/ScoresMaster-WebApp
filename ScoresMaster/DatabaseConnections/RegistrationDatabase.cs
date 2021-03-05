using MySql.Data.MySqlClient;
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
        public bool StoreUserData(string Fname, string Lname, string Email, string Password, DateTime BirthDay)
        {
            string Api_key = RandomString();
            Database.PAPI_Key = Api_key;
            string StoreData = "INSERT INTO `user`(`first_name`, `last_name`, `email`, `password`, `last_login`, `birth_date`, `api_key`) VALUES ('" + Fname + "','" + Lname + "','" + Email + "','" + Password + "', '2020-12-02 14:16:47','" + BirthDay + "', '" + Api_key + "');";
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
        internal bool StoreUser(RegistrationModel registration)
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
        public bool Registrate(RegistrationModel registration)
        {
            return StoreUser(registration);
        }
        //public string HashPassword(string password)
        //{
        //    SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider();

        //    byte[] password_bytes = Encoding.ASCII.GetBytes(password);
        //    byte[] encrypted_bytes = SHA1.ComputeHash(password_bytes);
        //    return Convert.ToBase64String(encrypted_bytes);
        //}
    }
}