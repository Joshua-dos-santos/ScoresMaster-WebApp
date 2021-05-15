using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    class PlayerDAO
    {
        public int PlayerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Shirt_Number { get; set; }
        public PositionDAO Position { get; set; }
        public CountryDAO Nationality { get; set; }
        public DateTime Birth_Day { get; set; }

        public PlayerDAO(PlayerDTO playerDTO)
        {
            PositionDTO positionDTO = new PositionDTO();
            PositionDAO positionDAO = new PositionDAO(positionDTO);
            PlayerID = playerDTO.PlayerID;
            First_Name = playerDTO.First_Name;
            Last_Name = playerDTO.Last_Name;
            Shirt_Number = playerDTO.Shirt_Number;
            Position = positionDAO;
        }
    }
}
