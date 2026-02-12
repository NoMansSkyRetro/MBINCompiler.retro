using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EAA5CC7010BC004, NameHash = 0x32EF8A95)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 3)]
        /* 0x410 */ public List<NMSString0x100> DispenseNodes;
        [NMS(Index = 5)]
        /* 0x420 */ public float DispensePeriod;
        [NMS(Index = 4)]
        /* 0x424 */ public float DispenseVelocity;
        [NMS(Index = 1)]
        /* 0x428 */ public int NumInputs;
        [NMS(Index = 2)]
        /* 0x42C */ public int NumMealsPerBait;
    }
}
