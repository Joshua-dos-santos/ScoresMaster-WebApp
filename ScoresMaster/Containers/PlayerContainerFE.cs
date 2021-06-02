using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class PlayerContainerFE
    {

        DataManager.Business.Containers.PlayerContainer playerContainer = new DataManager.Business.Containers.PlayerContainer();
        GeographicalContainerFE GeographicalContainer = new GeographicalContainerFE();


        public List<Player> GetAllPlayersByClub(int id)
        {
            List<Player> players = new List<Player>();
            var player = playerContainer.GetAllPlayersByClub(id);
            foreach (var m in player)
            {
                players.Add(new Player(m) { Position = GetPosition(m.Position.unique_id), Nationality = GeographicalContainer.GetCountry(m.Nationality.CountryID) });
            }
            return players;
        }

        public List<Player> GetAllPlayersByCountry(int id)
        {
            List<Player> players = new List<Player>();
            var player = playerContainer.GetAllPlayersByCountry(id);
            foreach (var m in player)
            {
                players.Add(new Player(m) { Position = GetPosition(m.Position.unique_id), Nationality = GeographicalContainer.GetCountry(m.Nationality.CountryID) });
            }
            return players;
        }
        
        public Player GetPlayer(int id)
        {
            var player = playerContainer.GetPlayer(id);
            Player newPlayer = new Player(player) { Position = GetPosition(player.Position.unique_id), Nationality = GeographicalContainer.GetCountry(player.Nationality.CountryID) };
            return newPlayer;
        }

        public Position GetPosition(int id)
        {
            var position = playerContainer.GetPosition(id);
            Position positions = new Position(position);
            return positions;
        }
    }
}