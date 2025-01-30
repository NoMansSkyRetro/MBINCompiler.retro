using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E063C23543EFF0A, NameHash = 0xBDB2EAAD)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public float[] CivilianClassWeightings;
    }
}
