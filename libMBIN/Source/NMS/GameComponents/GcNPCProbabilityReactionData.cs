using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76C17DBD42B6FE7, NameHash = 0xD0E53EEB)]
    public class GcNPCProbabilityReactionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcNPCRaceProbabilityModifierData> RaceModifiers;
        [NMS(Index = 1)]
        /* 0x20 */ public float Probability;
    }
}
