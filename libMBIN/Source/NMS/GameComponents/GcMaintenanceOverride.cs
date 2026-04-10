using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E6B4DDA68C46D42, NameHash = 0xEEECBBD3)]
    public class GcMaintenanceOverride : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcMaintenanceComponentData Data;
        [NMS(Index = 0)]
        /* 0x430 */ public NMSString0x10 ID;
    }
}
