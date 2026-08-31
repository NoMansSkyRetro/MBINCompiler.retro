using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Size = 0x4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public Colour[] ColourByStarType;
    }
}
