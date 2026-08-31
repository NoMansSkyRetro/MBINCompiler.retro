using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    // 1.13/1.24 layout (byte-identical per GUID census): the base (1.09.1-era) layout with
    // one float inserted at 0x98 and four floats appended at 0xC8. Payload 0xD8 = 216,
    // verified against GCAUDIOGLOBALS.GLOBAL.MBIN from both installs.
    public class GcAudioGlobals : NMSTemplate
    {
        // the func that uses the blocks of floats below (up to 0x3C) seems to associate each 3 with a different NPC type
        public float Unknown0; // None
        public float Unknown4; // None
        public float Unknown8; // None
        public float UnknownC; // Pirate
        public float Unknown10; // Pirate
        public float Unknown14; // Pirate
        public float Unknown18; // Police
        public float Unknown1C; // Police
        public float Unknown20; // Police
        public float Unknown24; // Trader
        public float Unknown28; // Trader
        public float Unknown2C; // Trader
        public float Unknown30; // Freighter
        public float Unknown34; // Freighter
        public float Unknown38; // Freighter

        public float Unknown3C;
        public float Unknown40;
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;
        public float Unknown50;
        public float Unknown54;
        public float Unknown58;
        public float Unknown5C;
        public float Unknown60;
        public float Unknown64;
        public float Unknown68;
        public float Unknown6C;
        public float Unknown70;
        public float Unknown74;
        public float Unknown78;
        public float Unknown7C;
        public float Unknown80;
        public float Unknown84;
        public float Unknown88;
        public float Unknown8C;
        public float Unknown90;
        public float Unknown94;
        public float Unknown98; // added in Foundation (0.9 in shipped globals)
        public float Unknown9C;
        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;
        public float UnknownAC;

        public bool UnknownB0; // if false, main code chunk inside cGcAudioManager::RunObstructionQueries won't get run (default true)

        public float UnknownB4;
        public float UnknownB8;
        public float UnknownBC;
        public float UnknownC0;

        public bool UnknownC4; // if true, loads music from /MUSIC/PULSE.XML? (default true)

        [NMS(Size = 3, Ignore = true)]
        public byte[] PaddingC5;

        public float UnknownC8; // added in Foundation (4000)
        public float UnknownCC; // (40000)
        public float UnknownD0; // (250)
        public float UnknownD4; // (3000)
    }
}
