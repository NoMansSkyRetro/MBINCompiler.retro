namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB0097874841CCD61, NameHash = 0x89B44B6A)]
    public class TkNGuiForcedStyle : NMSTemplate
    {
        // size: 0x4
        public enum NGuiForcedStyleEnum : uint {
            None,
            Default,
            Highlight,
            Active,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NGuiForcedStyleEnum NGuiForcedStyle;
    }
}
