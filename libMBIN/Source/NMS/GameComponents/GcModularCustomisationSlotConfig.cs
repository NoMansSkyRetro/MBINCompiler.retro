using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x754F48655614C169, NameHash = 0xE45C3809)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcModularCustomisationSlotItemData SlotEmptyCustomisation;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A LabelLocID;
        [NMS(Index = 11)]
        /* 0x60 */ public List<NMSString0x10> AdditionalSlottableItemLists;
        [NMS(Index = 8)]
        /* 0x70 */ public List<NMSString0x20> AssociatedNonProcNodes;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x10 SlotID;
        [NMS(Index = 10)]
        /* 0x90 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
        [NMS(Index = 7)]
        /* 0xA0 */ public NMSString0x10 UISlotGraphicLayer;
        [NMS(Index = 6)]
        /* 0xB0 */ public Vector2f UISlotPosition;
        [NMS(Index = 3)]
        /* 0xB8 */ public float UILineLengthFactor;
        [NMS(Index = 4)]
        /* 0xBC */ public float UILineMaxAngle;
        [NMS(Index = 5)]
        /* 0xC0 */ public NMSString0x20 UILocatorName;
        [NMS(Index = 2)]
        /* 0xE0 */ public bool IncludeInSeed;
    }
}
