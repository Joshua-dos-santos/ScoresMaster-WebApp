using DataManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Business.DAO
{
    class Primary_ColorDAO
    {
        public int ColorID { get; set; }
        public string Colors { get; set; }

        public Primary_ColorDAO(Primary_ColorDTO primary_ColorDTO)
        {
            ColorID = primary_ColorDTO.ColorID;
            Colors = primary_ColorDTO.Colors;
        }
    }
}
