namespace DataManager.Data.DTO
{
    public class LoginDTO
    {
        public string Unique_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ClubDTO Favorite_Club { get; set; }
    }
}
