using DataManager.Business.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoresMaster.Models
{
    public class Primary_Color
    {
        public int ColorID { get; set; }
        public string Colors { get; set; }

        public Primary_Color()
        {

        }
        public Primary_Color(Primary_ColorDAO primary_ColorDAO)
        {
            ColorID = primary_ColorDAO.ColorID;
            Colors = primary_ColorDAO.Colors;
        }
    }
}