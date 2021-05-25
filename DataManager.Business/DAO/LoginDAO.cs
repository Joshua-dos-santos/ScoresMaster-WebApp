using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    public class LoginDAO
    {
        public string Unique_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginDAO(LoginDTO loginDTO)
        {
            Unique_id = loginDTO.Unique_id;
            First_Name = loginDTO.First_Name;
            Last_Name = loginDTO.Last_Name;
            Email = loginDTO.Email;
            Password = loginDTO.Password;
        }
    }
}
