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
        
        public static League GetLeagues(int LeagueID, League league)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getLeagues = new MySqlCommand("SELECT * FROM `league` WHERE `unique_id`=@val1", databaseConnection);
            getLeagues.Parameters.AddWithValue("@val1", LeagueID);
            try
            {
                databaseConnection.Open();
                getLeagues.Prepare();
                var executeString = getLeagues.ExecuteReader();
                while (executeString.Read())
                {
                    league.Name = executeString.GetString(1);
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return league;
        }
    }
}