using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x127CF421C750A33D, NameHash = 0x952196ED)]
    public class GcModSettings : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcModSettingsInfo> Data;
        [NMS(Index = 0)]
        /* 0x10 */ public bool DisableAllMods;
    }
}
