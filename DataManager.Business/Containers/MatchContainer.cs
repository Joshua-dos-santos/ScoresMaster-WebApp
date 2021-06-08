using DataManager.Business.DAO;
using DataManager.Data.Logic;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class MatchContainer
    {
       
        public List<MatchDAO> GetAllMatches(int id)
        {
            Data.Logic.MatchAPIContext context = new Data.Logic.MatchAPIContext();
            ClubContainer clubContainer = new ClubContainer();
            Data.Repositories.MatchRepository repo = new Data.Repositories.MatchRepository(context);
            
            List<MatchDAO> matches = new List<MatchDAO>();
            var matchDto = repo.GetAllMatches(id);
            foreach(var dto in matchDto)
            {
                matches.Add(new MatchDAO(dto) {Home_Team = clubContainer.GetClubByName(dto.Home_Team.Name), Away_Team = clubContainer.GetClubByName(dto.Away_Team.Name) });
            }
            return matches;
        }
    }
}
