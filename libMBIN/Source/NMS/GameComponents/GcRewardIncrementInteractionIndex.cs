using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C6A7A503D23823C, NameHash = 0x15944A2F)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcInteractionType InteractionToIncrement;
        [NMS(Index = 1)]
        /* 0x4 */ public GcAlienRace Race;
    }
}
