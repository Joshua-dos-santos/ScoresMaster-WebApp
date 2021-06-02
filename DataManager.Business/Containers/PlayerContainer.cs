using DataManager.Business.DAO;
using DataManager.Data.Repositories;
using System.Collections.Generic;

namespace DataManager.Business.Containers
{
    public class PlayerContainer
    {
        Data.Logic.PlayerDatabaseContext context = new Data.Logic.PlayerDatabaseContext();
        GeographicalContainer geographicalContainer = new GeographicalContainer();

        public List<PlayerDAO> GetAllPlayersByClub(int id)
        {
            PlayerRepository repo = new PlayerRepository(context);

            List<PlayerDAO> players = new List<PlayerDAO>();
            var playerdto = repo.GetAllPlayersByClub(id);
            foreach (var dto in playerdto)
            {
                players.Add(new PlayerDAO(dto) { Position = GetPosition(dto.Position.unique_id), Nationality = geographicalContainer.GetCountry(dto.Nationality.CountryID) });
            }
            return players;
        }
        public List<PlayerDAO> GetAllPlayersByCountry(int id)
        {
            PlayerRepository repo = new PlayerRepository(context);

            List<PlayerDAO> players = new List<PlayerDAO>();
            var playerdto = repo.GetAllPlayersByCountry(id);
            foreach (var dto in playerdto)
            {
                players.Add(new PlayerDAO(dto) { Position = GetPosition(dto.Position.unique_id), Nationality = geographicalContainer.GetCountry(dto.Nationality.CountryID) });
            }
            return players;
        }

        public PlayerDAO GetPlayer(int id)
        {
            PlayerRepository repo = new PlayerRepository(context);
            var player = repo.GetPlayer(id);
            PlayerDAO playerDAO = new PlayerDAO(player) { Position = GetPosition(player.Position.unique_id), Nationality = geographicalContainer.GetCountry(player.Nationality.CountryID) };
            return playerDAO;
        }

        public PositionDAO GetPosition(int id)
        {
            PlayerRepository repo = new PlayerRepository(context);
            var position = repo.GetPosition(id);
            PositionDAO positionDAO = new PositionDAO(position);
            return positionDAO;
        }
    }
}
