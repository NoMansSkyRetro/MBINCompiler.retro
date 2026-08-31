using System.Collections.Generic;

namespace libMBIN.V1_13.Structs
{
    public class TkProceduralTextureLayer : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;

        public float Probability;
        public int Unknown14;

        [NMS(Size = 0x10)]
        public string Group;

        public bool SelectToMatchBase;
        public List<TkProceduralTexture> Textures;
    }
}
