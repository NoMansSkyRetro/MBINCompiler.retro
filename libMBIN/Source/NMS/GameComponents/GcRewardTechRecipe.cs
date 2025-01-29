using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A4AD49ADDD25B59, NameHash = 0x14395E2)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 RewardGroup;
        [NMS(Index = 0)]
        /* 0x10 */ public GcTechnologyCategory Category;
    }
}
