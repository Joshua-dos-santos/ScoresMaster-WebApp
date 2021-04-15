using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class ClubDatabase
    {
        public static Club GetHome_Team(Club club, Match match)
        {
            League league = new League();
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getClubs = new MySqlCommand("SELECT * FROM `club` WHERE `club_name`=@val1", databaseConnection);
            getClubs.Parameters.AddWithValue("@val1", match.Home_Team);
            try
            {
                databaseConnection.Open();
                getClubs.Prepare();
                var executeString = getClubs.ExecuteReader();
                while (executeString.Read())
                {
                    club.ClubID = executeString.GetInt32(0);
                    club.Name = match.Home_Team;
                    club.League = league;
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return club;
        }

        public static Club GetAway_Team(Club club, Match match)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getClubs = new MySqlCommand("SELECT * FROM `club` WHERE `club_name`=@val1", databaseConnection);
            getClubs.Parameters.AddWithValue("@val1", match.Away_Team);
            try
            {
                databaseConnection.Open();
                getClubs.Prepare();
                var executeString = getClubs.ExecuteReader();
                while (executeString.Read())
                {
                    club.ClubID = executeString.GetInt32(0);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return club;
        }
    }
}