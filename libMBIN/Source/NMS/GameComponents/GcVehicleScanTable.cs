using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4CC7F6D29F30F22, NameHash = 0x65A159FE)]
    public class GcVehicleScanTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}
