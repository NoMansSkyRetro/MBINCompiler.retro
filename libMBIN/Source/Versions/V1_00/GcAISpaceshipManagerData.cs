using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcAISpaceshipManagerData : NMSTemplate // disc: 5 factions (release adds a 6th)
    {
        [NMS(Size = 5)]
        public GcAISpaceshipMappingData[] FactionMapping;
    }
}
