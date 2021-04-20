using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class CountyDatabase
    {
        //public static Country GetCountry(Country country)
        //{
        //    MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
        //    MySqlCommand getCountry = new MySqlCommand("SELECT * FROM `country` WHERE `unique_id`=@val1", databaseConnection);
        //    getCountry.Parameters.AddWithValue("@val1", country.CountryID);
        //    try
        //    {
        //        databaseConnection.Open();
        //        getCountry.Prepare();
        //        var executeString = getCountry.ExecuteReader();
        //        while (executeString.Read())
        //        {
        //            country.Name = executeString.GetString(1);
        //        }
        //    }
        //}
    }
}