using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_09_1.Structs
{
    // Derived from the 1.09.1 file (payload 0x50): the launch layout with an int Version
    // prepended and NumHighThreads/NumLowThreads appended. Decodes 1920x1080, FoV 75.0,
    // Brightness 128, MaxframeRate 30 at the expected offsets.
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public int Version;
        /* 0x04 */ public bool FullScreen;
        /* 0x05 */ public bool Borderless;
        /* 0x08 */ public int Monitor;
        /* 0x0C */ public bool UseScreenResolution;
        /* 0x10 */ public int ResolutionWidth;
        /* 0x14 */ public int ResolutionHeight;
        /* 0x18 */ public bool VSync;
        /* 0x19 */ public bool GSync;
        /* 0x1C */ public int ShadowDetail;
        public string[] ShadowDetailValues()
        {
            return new string[] { "Low", "Normal", "High", "Ultra" };
        }
        /* 0x20 */ public int TextureDetail;
        public string[] TextureDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x24 */ public int GenerationDetail;
        public string[] GenerationDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x28 */ public int ReflectionsQuality;
        public string[] ReflectionsQualityValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x2C */ public int AntiAliasing;
        public string[] AntiAliasingValues()
        {
            return new string[] { "None", "FXAA", "SSAA4" };
        }
        /* 0x30 */ public int AnisotropyLevel;
        /* 0x34 */ public float FoVOnFoot;
        /* 0x38 */ public float FoVInShip;
        /* 0x3C */ public int Brightness;
        /* 0x40 */ public int MaxframeRate;
        /* 0x44 */ public bool NoHudMode;
        /* 0x48 */ public int NumHighThreads;
        /* 0x4C */ public int NumLowThreads;
    }
}
