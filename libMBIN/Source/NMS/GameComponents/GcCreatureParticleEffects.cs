using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF189FD110D5AC87E, NameHash = 0x45284367)]
    public class GcCreatureParticleEffects : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureParticleEffectData> ParticleEffects;
    }
}
