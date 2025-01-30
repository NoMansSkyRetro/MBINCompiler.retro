using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB5DD36649BDFB2ED, NameHash = 0x80B003EE)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x00 */ public int[] CloudsMaxIterations;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x10 */ public float[] CloudsResolutionScale;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x20 */ public float[] IKFullBodyIterations;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x30 */ public float[] ReflectionProbesMultiplier;
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x40 */ public float[] ShadowMultiplier;
        [NMS(Index = 5, Size = 0x36, EnumType = typeof(TkEngineSettingTypes.EngineSettingEnum))]
        /* 0x50 */ public bool[] NeedsGameRestart;
    }
}
