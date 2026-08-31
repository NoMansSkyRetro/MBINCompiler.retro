using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    public class GcCreatureInfo : NMSTemplate // disc 0x300: six strings, no Age/floats/Rarity
    {
        public NMSString0x80 Gender1;
        public NMSString0x80 Gender2;
        public NMSString0x80 Temperament;
        public NMSString0x80 Diet;
        public NMSString0x80 Weight1;
        public NMSString0x80 Height1;
    }
}
