namespace libMBIN.V1_38.Structs
{
    public class GcTileTypeSet : NMSTemplate        // size: 0x64
    {
        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
