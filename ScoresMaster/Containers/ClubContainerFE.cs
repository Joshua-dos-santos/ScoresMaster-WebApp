using DataManager.Business.Containers;
using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class ClubContainerFE
    {
        ClubContainer clubContainer = new ClubContainer();

        //public List<Club> GetAllClubs()
        //{
        //    List<Club> clubs = new List<Club>();
        //    var clubdao = clubContainer.GetAllClubs();
        //    foreach (var club in clubdao)
        //    {
        //        clubs.Add(new Club(club));
        //    }
        //    return clubs;
        //}

        public Club GetClub(string name)
        {
            var club = clubContainer.GetClub(name);
            Club Clubs = new Club(club);
            return Clubs;
        }
    }
}