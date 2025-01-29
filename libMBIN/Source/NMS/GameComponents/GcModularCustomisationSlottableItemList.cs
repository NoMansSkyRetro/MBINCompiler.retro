using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDC5F76F3EBDF682, NameHash = 0xDCC36C7C)]
    public class GcModularCustomisationSlottableItemList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ListID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
    }
}
