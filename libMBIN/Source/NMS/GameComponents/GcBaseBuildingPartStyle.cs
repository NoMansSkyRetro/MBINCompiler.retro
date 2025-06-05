namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA9AC36BBC64454D, NameHash = 0xB2FCF6E3)]
    public class GcBaseBuildingPartStyle : NMSTemplate
    {
        // size: 0x8
        public enum StyleEnum : uint {
            None,
            Wood,
            Metal,
            Concrete,
            Stone,
            Timber,
            Fibreglass,
            Builders,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StyleEnum Style;
    }
}
