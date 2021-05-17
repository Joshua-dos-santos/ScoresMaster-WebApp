using DataManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    public class ContinentDAO
    {
        public int ContinentID { get; set; }
        public string Continents { get; set; }

        public ContinentDAO(ContinentDTO continentDTO)
        {
            ContinentID = continentDTO.ContinentID;
            Continents = continentDTO.Continents;
        }
    }
}
