using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Position
    {
        public int unique_id { get; set; }
        public string Positions { get; set; }

        public Position(PositionDAO positionDAO)
        {
            unique_id = positionDAO.unique_id;
            Positions = positionDAO.Positions;
        }

        public Position()
        {

        }
    }
}