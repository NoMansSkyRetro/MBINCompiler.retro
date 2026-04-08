using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E2ABC651EE97E18, NameHash = 0x4AEB3F96)]
    public class GcSettlementColourUpgradeBuildingOverride : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A BuildingPalette;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A DecorationPalette;
        [NMS(Index = 0)]
        /* 0x40 */ public GcBuildingClassification Building;
    }
}
