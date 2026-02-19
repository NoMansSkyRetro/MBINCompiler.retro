using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD4FBDDAC3B722AD, NameHash = 0x77A67F2A)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 3)]
        /* 0x410 */ public Vector3f InputOffset;
        [NMS(Index = 4)]
        /* 0x420 */ public Vector3f OutputOffset;
        [NMS(Index = 1)]
        /* 0x430 */ public int NumInputs;
        [NMS(Index = 2)]
        /* 0x434 */ public bool IsCooker;
    }
}
