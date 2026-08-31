using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
namespace libMBIN.V1_09_1.Structs
{
    // 1.09.1: the StatIds list comes first (the era def had Id/Icon first)
    public class GcStatsGroup : NMSTemplate
    {
        public List<GcStatsEntry> StatIds;
        public NMSString0x10 Id;
        public TkTextureResource Icon;
    }
}
