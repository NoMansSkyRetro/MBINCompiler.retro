using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcTextPreset : NMSTemplate
    {
        public GcFontTypesEnum FontType;
        public NMSTemplate TextStyle;

        public float Height;
        public Colour Colour;
    }
}
