using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.DTO
{
    class PlayerDAO
    {
        public int PlayerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Shirt_Number { get; set; }
        public PositionDAO Position { get; set; }
        public CountryDTO Nationality { get; set; }
        public DateTime Birth_Day { get; set; }
    }
}
