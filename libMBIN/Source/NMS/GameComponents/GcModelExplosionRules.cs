using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33C7016C2DC79BC5, NameHash = 0xE59ABC9B)]
    public class GcModelExplosionRules : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcModelExplosionRule> Rules;
        [NMS(Index = 2, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x10 */ public float[] ShipSalvageDisplayScales;
        [NMS(Index = 1, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x3C */ public bool[] UseRules;
    }
}
