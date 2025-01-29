using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF0F0FA8F7201346E, NameHash = 0x4CF0C331)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x8)]
        /* 0x000 */ public TkProceduralTextureLayer[] Layers;
        [NMS(Index = 0)]
        /* 0x1C0 */ public bool AlwaysEnableUnnamedTextureLayers;
    }
}
