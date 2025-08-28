using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F782F3CEC9BE992, NameHash = 0x363A19F4)]
    public class GcSettlementMaterialTable : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x4)]
        /* 0x000 */ public GcSettlementMaterialData[] UpgradeLevels;
        [NMS(Index = 0)]
        /* 0x100 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x110 */ public float RelativeProbability;
        [NMS(Index = 1)]
        /* 0x114 */ public GcBaseBuildingPartStyle Style;
    }
}
