using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A53376884FA1DFA, NameHash = 0xDF48072A)]
    public class GcSentinelSpawnWave : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSentinelSpawnData> Spawns;
        [NMS(Index = 2)]
        /* 0x20 */ public int ReinforceAt;
    }
}
