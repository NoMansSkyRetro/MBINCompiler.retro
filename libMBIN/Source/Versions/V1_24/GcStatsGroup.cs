using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcStatsGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public TkTextureResource Icon;

        public List<GcStatsEntry> StatIds;
    }
}
