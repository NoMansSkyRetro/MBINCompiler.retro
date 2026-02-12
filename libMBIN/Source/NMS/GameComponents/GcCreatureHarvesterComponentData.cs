using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DFB9582A9732DE4, NameHash = 0x1DA81BEB)]
    public class GcCreatureHarvesterComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 1)]
        /* 0x410 */ public int NumSlots;
    }
}
