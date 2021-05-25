﻿using DataManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Interfaces
{
    public interface ILoginContext
    {
        LoginDTO CheckLogin(string email, string password);
        LoginDTO GetUserDetails(string id);
    }
}
