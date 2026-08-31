namespace libMBIN.V1_24.Structs
{
    public class GcGalaxyStarColours : NMSTemplate      // size: 0x40
    {
        [NMS(Size = 0x4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public Colour[] ColourByStarType;
    }
}
