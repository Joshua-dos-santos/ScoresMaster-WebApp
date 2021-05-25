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
    public class RegisterDatabaseContext : IRegisterContext
    {
        public string RandomString()
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

        public RegisterDTO StoreUserData(string Fname, string Lname, string email, string password, string birthdate)
        {
            RegisterDTO register = new RegisterDTO { First_Name = Fname, Last_Name = Lname, EMail = email, Password = password, Birth_Day = birthdate};
            string unique_Code = RandomString();
            DatabaseDTO.PAPI_Key = unique_Code;
            MySqlConnection databaseConnection = new MySqlConnection(DatabaseDTO.DbConnectionString);
            MySqlCommand insertUserData = new MySqlCommand("INSERT INTO `user`(`first_name`, `last_name`, `email`, `password`, `birth_date`, `api_key`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6);", databaseConnection);
            insertUserData.Parameters.AddWithValue("@val1", Fname);
            insertUserData.Parameters.AddWithValue("@val2", Lname);
            insertUserData.Parameters.AddWithValue("@val3", email);
            insertUserData.Parameters.AddWithValue("@val4", password);
            insertUserData.Parameters.AddWithValue("@val5", birthdate);
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
            return register;

        }
    }
}
