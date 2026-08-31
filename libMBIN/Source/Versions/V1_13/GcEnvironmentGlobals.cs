using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_13.Structs
{
    // 1.13 layout, derived from the V1_09_1 def: 864 bytes; without the class alignment override the root
    // end-aligns to 16 (Vector4f fields) and writes 816
    [NMS(Alignment = 0x8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        // Vector4f fields below might be Colour fields instead

        public Vector4f Unknown0;

        public bool Unknown10;
        public bool Unknown11;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;

        public Vector4f Unknown20;
        public Vector4f Unknown30;
        public Vector4f Unknown40;
        public Vector4f Unknown50;

        public bool Unknown60;
        public float Unknown64;
        public int Unknown68;
        public float Unknown6C;

        public Vector4f Unknown70;
        public Vector4f Unknown80;
        public Vector4f Unknown90;
        public Vector4f UnknownA0;
        public Vector4f UnknownB0;
        public Vector4f UnknownC0;
        public Vector4f UnknownD0;
        public Vector4f UnknownE0;
        public Vector4f UnknownF0;
        public Vector4f Unknown100;
        // 1.13: the 0x110 region is 51 plain floats (the 1.09.1 vectors plus 15 more values)
        public float Unknown110;
        public float Unknown114;
        public float Unknown118;
        public float Unknown11C;
        public float Unknown120;
        public float Unknown124;
        public float Unknown128;
        public float Unknown12C;
        public float Unknown130;
        public float Unknown134;
        public float Unknown138;
        public float Unknown13C;
        public float Unknown140;
        public float Unknown144;
        public float Unknown148;
        public float Unknown14C;
        public float Unknown150;
        public float Unknown154;
        public float Unknown158;
        public float Unknown15C;
        public float Unknown160;
        public float Unknown164;
        public float Unknown168;
        public float Unknown16C;
        public float Unknown170;
        public float Unknown174;
        public float Unknown178;
        public float Unknown17C;
        public float Unknown180;
        public float Unknown184;
        public float Unknown188;
        public float Unknown18C;
        public float Unknown190;
        public float Unknown194;
        public float Unknown198;
        public float Unknown19C;
        public float Unknown1A0;
        public float Unknown1A4;
        public float Unknown1A8;
        public float Unknown1AC;
        public float Unknown1B0;
        public float Unknown1B4;
        public float Unknown1B8;
        public float Unknown1BC;
        public float Unknown1C0;
        public float Unknown1C4;
        public float Unknown1C8;
        public float Unknown1CC;
        public float Unknown1D0;
        public float Unknown1D4;
        public float Unknown1D8;

        public bool Unknown1DC;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding1DD;

        [NMS(Size = 3)]
        public TkShearWindData[] Unknown1E0;
    }
}
