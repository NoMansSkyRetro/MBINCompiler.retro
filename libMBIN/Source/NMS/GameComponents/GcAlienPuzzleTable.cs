using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA81E11583EDABF4B, NameHash = 0x3987E9FB)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienPuzzleEntry> Table;
    }
}
