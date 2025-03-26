using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11FA19F748F5D0D2, NameHash = 0x772EC25C)]
    public class GcEncounterComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> InteractMissionTable;
        [NMS(Index = 0)]
        /* 0x10 */ public GcEncounterType EncounterType;
    }
}
