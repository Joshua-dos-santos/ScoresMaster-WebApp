using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class ContinentDatabase
    {
        public static Continent GetContinent(Continent continent)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getContinent = new MySqlCommand("SELECT * FROM `primary_color` WHERE `unique_id`=@val1", databaseConnection);
            getContinent.Parameters.AddWithValue("@val1", continent.ContinentID);
            try
            {
                databaseConnection.Open();
                getContinent.Prepare();
                var executeString = getContinent.ExecuteReader();
                while (executeString.Read())
                {
                    continent.Continents = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return continent;
        }
    }
}