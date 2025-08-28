using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1FC273DAA80B6507, NameHash = 0x427DC96C)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
