namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x735554F86F2776DF, NameHash = 0xDE0BB566)]
    public class GcWFCDecorationTheme : NMSTemplate
    {
        // size: 0x2
        public enum WFCDecorationThemeEnum : uint {
            Default,
            Construction,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WFCDecorationThemeEnum WFCDecorationTheme;
    }
}
