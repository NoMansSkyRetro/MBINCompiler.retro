using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED4864D4543C1A0E, NameHash = 0xD9D7367B)]
    public class GcMissionConditionHasSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 1)]
        /* 0x4 */ public bool RequireComplete;
    }
}
