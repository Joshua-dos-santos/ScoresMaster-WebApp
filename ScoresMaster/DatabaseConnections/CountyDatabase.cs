﻿using MySql.Data.MySqlClient;
using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.DatabaseConnections
{
    public class CountyDatabase
    {
        public static Country GetCountry(Country country)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Database.DbConnectionString);
            MySqlCommand getCountry = new MySqlCommand("SELECT * FROM `country` WHERE `unique_id`=@val1", databaseConnection);
            getCountry.Parameters.AddWithValue("@val1", country.CountryID);
            try
            {
                databaseConnection.Open();
                getCountry.Prepare();
                var executeString = getCountry.ExecuteReader();
                while (executeString.Read())
                {
                    Continent newContinent = new Continent();
                    Primary_Color newPrimary_Color = new Primary_Color();
                    country.Name = executeString.GetString(1);
                    newContinent.ContinentID = executeString.GetInt32(2);
                    newContinent = ContinentDatabase.GetContinent(newContinent);
                    country.continent = newContinent;
                    newPrimary_Color.ColorID = executeString.GetInt32(3);
                    newPrimary_Color = ColorDatabase.Get_Color(newPrimary_Color);
                    country.primary_Color = newPrimary_Color;
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return country;
        }
    }
}