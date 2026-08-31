using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Image;

        public Colour Colour;
    }
}
