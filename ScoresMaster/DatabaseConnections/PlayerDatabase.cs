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
        public string GetPlayers(int PlayerID, int ClubID)
        {
            string getFirstName = "SELECT `first_name` FROM `player` WHERE `unique_id`= '" + PlayerID + "'AND `club`= '"+ClubID+"'";
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand commandGetPlayer = new MySqlCommand(getFirstName, databaseConnection);
            commandGetPlayer.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader executeString = commandGetPlayer.ExecuteReader();
                while (executeString.Read())
                {
                    string Players = executeString.GetString(0);
                    databaseConnection.Close();
                    return Players;
                }
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