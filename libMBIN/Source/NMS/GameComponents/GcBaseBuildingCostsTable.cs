using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC2E210B2C2B1318, NameHash = 0x8069EA15)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}
