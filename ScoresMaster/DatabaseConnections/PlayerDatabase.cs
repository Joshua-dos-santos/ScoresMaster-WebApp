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
        public static List<Player> GetPlayers(Club club, Player player)
        {
            List<Player> Players = new List<Player>();
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getPlayers = new MySqlCommand("SELECT * FROM `player` WHERE `club`=@val1", databaseConnection);
            getPlayers.Parameters.AddWithValue("@val1", club.ClubID);
            try
            {
                databaseConnection.Open();
                getPlayers.Prepare();
                var executeString = getPlayers.ExecuteReader();
                while (executeString.Read())
                {
                    Player newPlayer = new Player();
                    newPlayer.First_Name = executeString.GetString(1);
                    newPlayer.Last_Name = executeString.GetString(2);
                    newPlayer.Shirt_Number = executeString.GetString(3);
                    newPlayer.Birth_Day = executeString.GetDateTime(7);
                    Players.Add(newPlayer);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return Players;
        }
    }
}