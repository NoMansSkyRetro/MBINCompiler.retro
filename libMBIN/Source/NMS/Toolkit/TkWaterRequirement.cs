namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF3A6E17909578177, NameHash = 0x7599DD43)]
    public class TkWaterRequirement : NMSTemplate
    {
        // size: 0x2
        public enum WaterRequirementEnum : uint {
            NoStorm,
            Storm,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WaterRequirementEnum WaterRequirement;
    }
}
