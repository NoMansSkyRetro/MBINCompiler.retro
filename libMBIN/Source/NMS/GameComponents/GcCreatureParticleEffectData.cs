using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x989AF9E290CCEA47, NameHash = 0x3C48FCCD)]
    public class GcCreatureParticleEffectData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcCreatureParticleEffectDataEntry> Effects;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCreatureParticleEffectTrigger RetireTriggers;
        [NMS(Index = 0)]
        /* 0x14 */ public GcCreatureParticleEffectTrigger SpawnTriggers;
    }
}
