using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3483C59EB629F021, NameHash = 0xD585FDA4)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcBuildingClassification BuildingType;
        [NMS(Index = 0)]
        /* 0x4 */ public bool UseInteractionBuildingType;
    }
}
