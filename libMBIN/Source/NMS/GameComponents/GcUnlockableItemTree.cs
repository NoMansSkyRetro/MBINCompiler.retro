using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E5128182B171A0F, NameHash = 0xDC4801D)]
    public class GcUnlockableItemTree : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcUnlockableItemTreeNode Root;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 CostTypeID;
    }
}
