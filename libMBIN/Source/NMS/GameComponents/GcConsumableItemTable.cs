using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA54141445A7F38EF, NameHash = 0x7D54F1EF)]
    public class GcConsumableItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcConsumableItem> Table;
    }
}
