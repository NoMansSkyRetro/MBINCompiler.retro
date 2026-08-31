using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class TkProceduralTexture : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;

        public TkPaletteTexture Palette;
        public float Probability;
        public int TextureGameplayUse;

        public string[] TextureGameplayUseValues()
        {
            return new[] { "IgnoreName", "MatchName", "DoNotMatchName" };
        }

        public bool OverrideAverageColour;
        public Colour AverageColour;

        [NMS(Size = 0x80)]
        public string Diffuse;

        [NMS(Size = 0x80)]
        public string Normal;

        [NMS(Size = 0x80)]
        public string Mask;
    }
}
