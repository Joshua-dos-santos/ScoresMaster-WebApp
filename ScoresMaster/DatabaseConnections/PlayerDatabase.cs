using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class PlayerDatabase
    {
        public static Player GetPlayers(int PlayerID, Player player)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getLeagues = new MySqlCommand("SELECT * FROM `league` WHERE `unique_id`=@val1", databaseConnection);
            getLeagues.Parameters.AddWithValue("@val1", PlayerID);
            try
            {
                databaseConnection.Open();
                getLeagues.Prepare();
                var executeString = getLeagues.ExecuteReader();
                while (executeString.Read())
                {
                    player.First_Name = executeString.GetString(1);
                    player.Last_Name = executeString.GetString(2);
                    player.Shirt_Number = executeString.GetString(3);
                    player.Birth_Day = executeString.GetDateTime(7);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return player;
        }
    }
}