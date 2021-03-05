using MySql.Data.MySqlClient;
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
            MySqlConnection databaseConnection = new MySqlConnection(Credentials.DbConnectionString);
            MySqlCommand commandGetRows = new MySqlCommand(getRows, databaseConnection);
            commandGetRows.CommandTimeout = 60;
        }
    }
}