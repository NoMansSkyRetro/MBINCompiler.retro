using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class TkProceduralTextureLayer : NMSTemplate
    {
        public NMSString0x10 Name;

        public float Probability;
        public int Unknown14;

        public NMSString0x10 Group;

        public bool SelectToMatchBase;
        public List<TkProceduralTexture> Textures;
    }
}
