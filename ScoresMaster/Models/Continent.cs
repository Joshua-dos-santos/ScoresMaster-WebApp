using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Continent
    {
        public int ContinentID { get; set; }
        public string Continents { get; set; }

        public Continent()
        {

        }
        public Continent(ContinentDAO continentDAO)
        {
            ContinentID = continentDAO.ContinentID;
            Continents = continentDAO.Continents;
        }
    }
}