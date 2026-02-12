using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74C9D2337635F98F, NameHash = 0x5CBD20D1)]
    public class GcVehicleScanTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 4)]
        /* 0x20 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x38 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 3)]
        /* 0x48 */ public List<GcVehicleScanTechReq> RequiredTechSeasonOverrides;
        [NMS(Index = 0)]
        /* 0x58 */ public List<NMSString0x20A> ScanList;
        [NMS(Index = 6)]
        /* 0x68 */ public GcVehicleType RequiredVehicle;
        [NMS(Index = 5)]
        /* 0x6C */ public bool UseRequiredVehicle;
    }
}
