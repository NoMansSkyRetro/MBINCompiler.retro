namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAC2AAC62E745C7FC, NameHash = 0x3C58F148)]
    public class TkWaterCondition : NMSTemplate
    {
        // size: 0xE
        public enum WaterConditionEnum : uint {
            Absolutely_Tranquil,
            Breezy_Lake,
            Wavy_Lake,
            Still_Pond,
            Agitated_Pond,
            Agitated_Lake,
            Surf,
            Big_Surf,
            Chaotic_Sea,
            Huge_Swell,
            Choppy_Sea,
            Very_Choppy_Sea,
            White_Horses,
            Ocean_Planet,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WaterConditionEnum WaterCondition;
    }
}
