using DataManager.Data.DTO;

namespace DataManager.Business.DAO
{
    public class PositionDAO
    {
        public int unique_id { get; set; }
        public string Positions { get; set; }

        public PositionDAO(PositionDTO positionDTO)
        {
            unique_id = positionDTO.unique_id;
            Positions = positionDTO.Positions;
        }
    }
}
