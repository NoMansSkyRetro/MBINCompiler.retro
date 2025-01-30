using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB91EAFC7BB99A886, NameHash = 0x40268557)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public Vector4f Direction;
        [NMS(Index = 7)]
        /* 0x010 */ public Vector4f Position;
        [NMS(Index = 2)]
        /* 0x020 */ public GcInventoryContainer Inventory;
        [NMS(Index = 3)]
        /* 0x178 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 4)]
        /* 0x2D0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 1)]
        /* 0x428 */ public GcResourceElement Resource;
        [NMS(Index = 5)]
        /* 0x470 */ public GcInventoryLayout InventoryLayout;
        [NMS(Index = 6)]
        /* 0x488 */ public ulong Location;
        [NMS(Index = 0)]
        /* 0x490 */ public NMSString0x20 Name;
    }
}
