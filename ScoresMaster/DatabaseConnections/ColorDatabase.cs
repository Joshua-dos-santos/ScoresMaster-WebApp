using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class ColorDatabase
    {
        public static Primary_Color Get_Color(Primary_Color color)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getColor = new MySqlCommand("SELECT * FROM `primary_color` WHERE `unique_id`=@val1", databaseConnection);
            getColor.Parameters.AddWithValue("@val1", color.ColorID);
            try
            {
                databaseConnection.Open();
                getColor.Prepare();
                var executeString = getColor.ExecuteReader();
                while (executeString.Read())
                {
                    color.Colors = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return color;
        } 
    }
}