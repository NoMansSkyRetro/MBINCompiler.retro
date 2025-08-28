using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC211DD3DBDAE7471, NameHash = 0xBDB2EAAD)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public float[] CivilianClassWeightings;
    }
}
