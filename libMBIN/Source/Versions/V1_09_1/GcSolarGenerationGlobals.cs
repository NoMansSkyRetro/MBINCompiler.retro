using libMBIN.NMS;

namespace libMBIN.V1_09_1.Structs
{
    public class GcSolarGenerationGlobals : NMSTemplate // 0x180
    {
        public bool Unknown0;

        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;

        public float Unknown10;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;

        public float MinPlanetDistance;
        public float MaxPlanetDistance;
        public bool Unknown28;
        public float Unknown2C;

        public bool Unknown30;
        public float Unknown34;
        public float Unknown38;
        public float Unknown3C;

        public float Unknown40;
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;

        public float Unknown50;
        public int Unknown54;
        public int Unknown58;
        public float Unknown5C;

        public int Unknown60;
        public int Unknown64;
        public float Unknown68;
        public float Unknown6C;

        public float AsteroidMinDistanceFromPlanets; // 0x70
        public int Unknown74;
        public float AsteroidNoiseDistribution;      // 0x78
        public float AsteroidSpreadDistribution;     // 0x7C

        public int Unknown80;
        public float Unknown84;
        public float Unknown88;
        public float AsteroidRotationXSpeed;         // 0x8C
        public float AsteroidRotationYSpeed;         // 0x90
        public float SmallAsteroidScaleVariance;     // 0x94

        public float Unknown98;
        public float Unknown9C;
        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;
        public float UnknownAC;
        public float UnknownB0;
        public float UnknownB4;

        /* 0xB8 */ public float SpecialAsteroidScale;
        /* 0xBC */ public int UnknownBC;
        /* 0xC0 */ public float UnknownC0;
        /* 0xC4 */ public int UnknownC4;
        /* 0xC8 */ public int SpecialAsteroidDropMin;
        /* 0xCC */ public int SpecialAsteroidDropMax;

        [NMS(Size = 0x10)]
        /* 0xD0 */ public string SpecialAsteroidDroppedItem;

        /* 0xE0 */ public float SmallAsteroidScale;
        /* 0xE4 */ public int UnknownE4;
        /* 0xE8 */ public float UnknownE8;
        /* 0xEC */ public int UnknownEC;
        /* 0xF0 */ public int SmallAsteroidDropMin;
        /* 0xF4 */ public int SmallAsteroidDropMax;

        [NMS(Size = 0x10)]
        /* 0xF8 */ public string SmallAsteroidDroppedItem;

        /* 0x108 */ public float Unknown108;
        /* 0x10C */ public float Unknown10C;
        /* 0x110 */ public float Unknown110;
        /* 0x114 */ public float Unknown114;
        /* 0x118 */ public float Unknown118;
        /* 0x11C */ public float Unknown11C;
        /* 0x120 */ public float Unknown120;
        /* 0x124 */ public int Unknown124;
        /* 0x128 */ public float Unknown128;
        /* 0x12C */ public float Unknown12C;
        /* 0x130 */ public float Unknown130;

        [NMS(Size = 0x13)]
        /* 0x134 */ public int[] Unknown134;
    }
}
