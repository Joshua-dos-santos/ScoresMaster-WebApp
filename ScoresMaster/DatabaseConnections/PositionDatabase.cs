using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class PositionDatabase
    {
        public static Position GetPosition(Position position)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getPosition = new MySqlCommand("SELECT * FROM `position` WHERE `unique_id`=@val1", databaseConnection);
            getPosition.Parameters.AddWithValue("@val1", position.unique_id);
            try
            {
                databaseConnection.Open();
                getPosition.Prepare();
                var executeString = getPosition.ExecuteReader();
                while (executeString.Read())
                {
                    position.Positions = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return position;
        }
    }
}