﻿using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using DataManager.Data.Logic;

namespace DataManager.Data.Repositories
{
    public class LoginRepository
    {
        private ILoginContext context;

        public LoginRepository(LoginDatabaseContext loginDatabaseContext)
        {
            this.context = loginDatabaseContext;
        }

        public LoginDTO CheckLogin(string email, string password)
        {
            return context.CheckLogin(email, password);
        }

        public LoginDTO GetUserDetails(string id)
        {
            return context.GetUserDetails(id);
        }
        public void UpdateFavoriteClub(int clubId, string userId)
        {
            context.UpdateFavoriteClub(clubId, userId);
        }
    }
}
