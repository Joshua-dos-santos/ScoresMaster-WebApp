using DataManager.Data;

namespace DataManager.Business.DAO
{
    public class Primary_ColorDAO
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
