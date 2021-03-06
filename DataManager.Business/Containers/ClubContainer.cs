﻿using DataManager.Business.DAO;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class ClubContainer
    {
            Data.Logic.ClubDatabaseContext context = new Data.Logic.ClubDatabaseContext();
            

        public List<ClubDAO> GetAllClubs()
        {
            Data.Repositories.ClubRepository repo = new Data.Repositories.ClubRepository(context);
            List<ClubDAO> clubs = new List<ClubDAO>();
            var clubDto = repo.GetAllclubs();
            foreach(var club in clubDto)
            {
                clubs.Add(new ClubDAO(club));
            }
            return clubs;
        }

        public ClubDAO GetClubByName(string name)
        {
            Data.Repositories.ClubRepository repo = new Data.Repositories.ClubRepository(context);
            var club = repo.GetClubByName(name);
           ClubDAO clubDAO = new ClubDAO(club);
            return clubDAO;
        }

        public ClubDAO GetClubByID(int id)
        {
            Data.Repositories.ClubRepository repo = new Data.Repositories.ClubRepository(context);
            var club = repo.GetClubByID(id);
            ClubDAO clubDAO = new ClubDAO(club);
            return clubDAO;
        }
    }
}
