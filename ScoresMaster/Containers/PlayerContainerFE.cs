using ScoresMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Containers
{
    public class PlayerContainerFE
    {

        DataManager.Business.Containers.PlayerContainer playerContainer = new DataManager.Business.Containers.PlayerContainer();


        public List<Player> GetAllPlayers(int id)
        {
            List<Player> players = new List<Player>();
            var player = playerContainer.GetAllPlayers(id);
            foreach (var m in player)
            {
                players.Add(new Player(m));
            }
            return players;
        }

        public List<Position> GetAllPositions()
        {
            List<Position> positions = new List<Position>();
            var position = playerContainer.GetAllPositions();
            foreach(var p in position)
            {
                positions.Add(new Position(p));
            }
            return positions;
        }

        public Position GetPosition(int id)
        {
            var position = playerContainer.GetPosition(id);
            Position positions = new Position(position);
            return positions;
        }
    }
}