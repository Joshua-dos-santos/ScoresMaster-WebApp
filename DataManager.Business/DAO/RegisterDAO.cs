using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    public class RegisterDAO
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Birth_Day { get; set; }

        public RegisterDAO(RegisterDTO registerDTO)
        {
            First_Name = registerDTO.First_Name;
            Last_Name = registerDTO.Last_Name;
            EMail = registerDTO.EMail;
            Password = registerDTO.Password;
            Birth_Day = registerDTO.Birth_Day;
        }
    }
}
