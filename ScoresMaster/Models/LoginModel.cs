using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class LoginModel
    {
        public string Unique_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Enter Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public LoginModel(LoginDAO login)
        {
            Unique_id = login.Unique_id;
            First_Name = login.First_Name;
            Last_Name = login.Last_Name;
            Email = login.Email;
            Password = login.Password;
        }
        public LoginModel()
        {

        }
    }
}