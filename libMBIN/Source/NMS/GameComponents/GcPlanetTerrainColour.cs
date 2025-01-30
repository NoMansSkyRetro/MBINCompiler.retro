using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD87AF8D04541C3B5, NameHash = 0xDA4AB69C)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkPaletteTexture Palette;
        [NMS(Index = 1)]
        /* 0xC */ public int Index;
    }
}
