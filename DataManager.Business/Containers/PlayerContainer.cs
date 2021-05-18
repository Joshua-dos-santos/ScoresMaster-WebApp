﻿using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.Containers
{
    public class PlayerContainer
    {
        Data.Logic.PlayerDatabaseContext context = new Data.Logic.PlayerDatabaseContext();

        public List<PlayerDAO> GetAllPlayers(int id)
        {
            Data.Repositories.PlayerRepository repo = new Data.Repositories.PlayerRepository(context);

            List<PlayerDAO> players = new List<PlayerDAO>();
            var playerdto = repo.GetAllPlayers(id);
            foreach (var dto in playerdto)
            {
                players.Add(new PlayerDAO(dto));
            }
            return players;
        }

        public List<PositionDAO> GetAllPositions()
        {
            Data.Repositories.PlayerRepository repo = new Data.Repositories.PlayerRepository();

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
            Data.Repositories.PlayerRepository repo = new Data.Repositories.PlayerRepository();
            var position = repo.GetPosition(id);
            PositionDAO positionDAO = new PositionDAO(position);
            return positionDAO;
        }
    }
}