namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF48DEC1B25631AC0, NameHash = 0x90014B83)]
    public class GcOptionsUIHeaderIcons : NMSTemplate
    {
        // size: 0x5
        public enum OptionsUIHeaderIconTypeEnum : uint {
            General,
            Ship,
            Cog,
            Scanner,
            Advanced,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public OptionsUIHeaderIconTypeEnum OptionsUIHeaderIconType;
    }
}
