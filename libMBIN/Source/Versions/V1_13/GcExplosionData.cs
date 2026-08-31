using libMBIN.NMS;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_13.Structs
{
    public class GcExplosionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkModelResource Model;
        /* 0x94 */ public GcAudioWwiseEvents AkEvent;
        /* 0x98 */ public List<GcDebrisData> Debris;
        /* 0xA8 */ public float Life;
        /* 0xAC */ public float Scale;
        /* 0xB0 */ public float DistanceScale;
        /* 0xB4 */ public bool CamShake;
        /* 0xB5 */ public byte UnknownB5;
        /* 0xB6 */ public ushort UnknownB6; // real 16-bit value hidden in the bool's alignment gap
        /* 0xB8 */ public float MaxSpawnDistance;
    
        // 1.13: a real value (looks like an id hash) in what 1.09.1 leaves as end padding
        public float UnknownBC;
}
}
