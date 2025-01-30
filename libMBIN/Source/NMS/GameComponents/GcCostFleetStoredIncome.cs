using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF411AD1F4FF2960E, NameHash = 0xD9D02175)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateClass Class;
        [NMS(Index = 1)]
        /* 0x4 */ public int RequiredAmount;
    }
}
