using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E7A9DB45E293C6D, NameHash = 0x6D785C93)]
    public class GcUnlockableItemTrees : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Title;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcUnlockableItemTree> Trees;
    }
}
