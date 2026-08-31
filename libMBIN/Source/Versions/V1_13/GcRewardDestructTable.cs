using libMBIN.NMS.GameComponents;
namespace libMBIN.V1_13.Structs
{
    public class GcRewardDestructTable : NMSTemplate
    {
        // 6 categories since Foundation (BuildingPart added); rc1/1.09.1 have 5
        [NMS(Size = 6)]
        public GcRewardDestructRarities[] Categories;
    }
}
