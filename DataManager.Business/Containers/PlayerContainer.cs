using DataManager.Business.DAO;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class PlayerContainer
    {
        Data.Logic.PlayerDatabaseContext context = new Data.Logic.PlayerDatabaseContext();
        GeographicalContainer geographicalContainer = new GeographicalContainer();

        public List<PlayerDAO> GetAllPlayers(int id)
        {
            Data.Repositories.PlayerRepository repo = new Data.Repositories.PlayerRepository(context);

            List<PlayerDAO> players = new List<PlayerDAO>();
            var playerdto = repo.GetAllPlayers(id);
            foreach (var dto in playerdto)
            {
                players.Add(new PlayerDAO(dto) { Position = GetPosition(dto.Position.unique_id), Nationality = geographicalContainer.GetCountry(dto.Nationality.CountryID) });
            }
            return players;
        }

        public List<PositionDAO> GetAllPositions()
        {
            Data.Repositories.PlayerRepository repo = new Data.Repositories.PlayerRepository(context);

            List<PositionDAO> positions = new List<PositionDAO>();
            var positiondto = repo.GetAllPositions();
            foreach(var position in positiondto)
            {
                positions.Add(new PositionDAO(position));
            }
            return positions;
        }

        public PositionDAO GetPosition(int id)
        {
            Data.Repositories.PlayerRepository repo = new Data.Repositories.PlayerRepository(context);
            var position = repo.GetPosition(id);
            PositionDAO positionDAO = new PositionDAO(position);
            return positionDAO;
        }
    }
}
