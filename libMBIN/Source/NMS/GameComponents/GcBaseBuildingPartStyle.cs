namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7048C6CBBDC70E27, NameHash = 0xB2FCF6E3)]
    public class GcBaseBuildingPartStyle : NMSTemplate
    {
        // size: 0x7
        public enum StyleEnum : uint {
            None,
            Wood,
            Metal,
            Concrete,
            Stone,
            Timber,
            Fibreglass,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StyleEnum Style;
    }
}
