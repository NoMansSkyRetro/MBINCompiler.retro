using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    // disc layout: 0x310. The float region between 0x50 and 0x18C reflows relative to
    // 1.09.1 (one float fewer, different packing), so it is kept flat until the PS4
    // exe gives real names.
    [NMS(Alignment = 0x8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        public Vector4f Unknown0;

        public bool Unknown10;
        public bool Unknown11;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;

        public Vector4f Unknown20;
        public Vector4f Unknown30;
        public Vector4f Unknown40;

        [NMS(Size = 79)]
        /* 0x050 */ public float[] Unknown50;

        /* 0x18C */ public bool Unknown18C;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding18D;

        [NMS(Size = 3)]
        /* 0x190 */ public TkShearWindData[] Unknown190;
    }
}
