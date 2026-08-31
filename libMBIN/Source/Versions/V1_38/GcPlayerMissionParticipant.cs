using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcPlayerMissionParticipant : NMSTemplate       // size: 0x20
    {
        public ulong UA;
        public GcSeed BuildingSeed;
        public ulong Unknown18;
    }
}
