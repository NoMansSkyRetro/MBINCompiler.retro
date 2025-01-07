using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA764C843CA59EE0E, NameHash = 0x26731382)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatDefinition> StatDefinitionTable;
    }
}
