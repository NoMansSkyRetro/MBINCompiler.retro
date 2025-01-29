using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2ECF6BECC87DDA8, NameHash = 0x427DC96C)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
