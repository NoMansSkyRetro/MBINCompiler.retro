using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2C76E0B2672F35C, NameHash = 0xC212E44)]
    public class GcActionSets : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSet> ActionSets;
    }
}
