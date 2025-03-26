using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEF3E1F64AB62010, NameHash = 0x5E8D0251)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBuildingClassification> ValidBuildings;
    }
}
