using DataManager.Business.Containers;
using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class ClubContainerFE
    {
        ClubContainer clubContainer = new ClubContainer();

        public List<Club> GetAllClubs()
        {
            List<Club> clubs = new List<Club>();
            var clubdao = clubContainer.GetAllClubs();
            foreach (var club in clubdao)
            {
                clubs.Add(new Club(club));
            }
            return clubs;
        }

        public Club GetClubByName(string name)
        {
            var club = clubContainer.GetClubByName(name);
            Club Clubs = new Club(club);
            return Clubs;
        }
        public Club GetClubByID(int id)
        {
            var club = clubContainer.GetClubByID(id);
            Club Clubs = new Club(club);
            return Clubs;
        }
    }
}