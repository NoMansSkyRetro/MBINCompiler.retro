using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x738B76A62E9BA052, NameHash = 0x4835E140)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericRewardTableEntry> Table;
    }
}
