using libMBIN.NMS; using libMBIN.NMS.GameComponents;
namespace libMBIN.V1_13.Structs
{
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        // 10 factions in the 1.13/1.24 files (rc1: 5, 1.09.1: 6)
        [NMS(Size = 10)]
        public GcAISpaceshipMappingData[] FactionMapping;
    }
}
