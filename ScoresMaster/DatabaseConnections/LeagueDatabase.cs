using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster
{
    public class LeagueDatabase
    {
        public string GetLeagues()
        {
            string getLeagues = "SELECT * FROM `league`";
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand commandGetLeagues = new MySqlCommand(getLeagues, databaseConnection);
            commandGetLeagues.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader executeString = commandGetLeagues.ExecuteReader();
                while (executeString.Read())
                {
                    string Leagues = executeString.GetString(0);
                    string allLeagues = Leagues;
                    databaseConnection.Close();
                    return allLeagues;
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