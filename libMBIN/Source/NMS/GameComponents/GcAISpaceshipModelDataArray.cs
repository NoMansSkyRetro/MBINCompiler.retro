using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEDB8C3AD9A872F2, NameHash = 0x241CDC95)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAISpaceshipModelData> Spaceships;
    }
}
