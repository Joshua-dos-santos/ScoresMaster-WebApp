using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        [DisplayName("First Name")]
        public string First_Name { get; set; }
        [DisplayName("Last Name")]
        public string Last_Name { get; set; }
        [DisplayName("Shirt Number")]
        public string Shirt_Number { get; set; }
        public Position Position { get; set; }
        public Country Nationality { get; set; }
        public DateTime Birth_Day { get; set; } 

        public Player(PlayerDAO playerDAO)
        {
            Position position = new Position();
            PlayerID = playerDAO.PlayerID;
            First_Name = playerDAO.First_Name;
            Last_Name = playerDAO.Last_Name;
            Shirt_Number = playerDAO.Shirt_Number;
            Position = position;
        }
        public Player()
        {

        }
       
    }
}