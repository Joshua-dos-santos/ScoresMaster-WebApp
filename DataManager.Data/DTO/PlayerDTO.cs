using System;

namespace DataManager.Data.DTO
{
    public class PlayerDTO
    {
        public int PlayerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Shirt_Number { get; set; }
        public PositionDTO Position { get; set; }
        public CountryDTO Nationality { get; set; }
        public DateTime Birth_Day { get; set; }
    }
}
