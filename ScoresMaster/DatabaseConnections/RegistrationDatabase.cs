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
        public static RegistrationModel StoreUserData(RegistrationModel registrationModel)
        {
            string unique_Code = RandomString();
            Database.PAPI_Key = unique_Code;
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand insertUserData = new MySqlCommand("INSERT INTO `user`(`first_name`, `last_name`, `email`, `password`, `birth_date`, `api_key`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6);", databaseConnection);
            insertUserData.Parameters.AddWithValue("@val1", registrationModel.First_Name);
            insertUserData.Parameters.AddWithValue("@val2", registrationModel.Last_Name);
            insertUserData.Parameters.AddWithValue("@val3", registrationModel.EMail);
            insertUserData.Parameters.AddWithValue("@val4", registrationModel.Password);
            insertUserData.Parameters.AddWithValue("@val5", registrationModel.Birth_Day);
            insertUserData.Parameters.AddWithValue("@val6", unique_Code);
            try
            {
                databaseConnection.Open();
                insertUserData.Prepare();
                var executeString = insertUserData.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return registrationModel;
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
    }
}