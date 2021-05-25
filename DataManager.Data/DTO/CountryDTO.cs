namespace DataManager.Data
{
    public class CountryDTO
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ContinentDTO continent { get; set; }
        public Primary_ColorDTO Primary_Color { get; set; }
    }
}
