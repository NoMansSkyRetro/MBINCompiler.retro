using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcAtlasMessage : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        [NMS(Size = 0x80)]
        public string CustomName;
        public Vector4f Positon;
        public int ColourIndex;
    }
}
