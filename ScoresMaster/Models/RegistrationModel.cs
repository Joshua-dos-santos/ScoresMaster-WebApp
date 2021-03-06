﻿using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class RegistrationModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Birth_Day { get; set; }

        public RegistrationModel(RegisterDAO registerDAO)
        {
            First_Name = registerDAO.First_Name;
            Last_Name = registerDAO.Last_Name;
            EMail = registerDAO.EMail;
            Password = registerDAO.Password;
            Birth_Day = registerDAO.Birth_Day;
        }
        public RegistrationModel()
        {

        }
    }
}