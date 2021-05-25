using ScoresMaster.Models;
using System.Collections.Generic;

namespace ScoresMaster.Containers
{
    public class PlayerContainerFE
    {

        DataManager.Business.Containers.PlayerContainer playerContainer = new DataManager.Business.Containers.PlayerContainer();
        GeographicalContainerFE GeographicalContainer = new GeographicalContainerFE();


        public List<Player> GetAllPlayers(int id)
        {
            List<Player> players = new List<Player>();
            var player = playerContainer.GetAllPlayers(id);
            foreach (var m in player)
            {
                players.Add(new Player(m) { Position = GetPosition(m.Position.unique_id), Nationality = GeographicalContainer.GetCountry(m.Nationality.CountryID) });
            }
            return players;
        }

        public Position GetPosition(int id)
        {
            var position = playerContainer.GetPosition(id);
            Position positions = new Position(position);
            return positions;
        }
    }
}