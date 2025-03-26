using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7FD24CB9E468CDF4, NameHash = 0x6CA73DFD)]
    public class GcCreatureParticleEffectTrigger : NMSTemplate
    {
        // size: 0x6
        [Flags]
        public enum CreatureParticleEffectTriggerEnum : uint {
            None = 0x0,
            Spawn = 0x1,
            Despawn = 0x2,
            Death = 0x4,
            Ragdoll = 0x8,
            Appear = 0x10,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureParticleEffectTriggerEnum CreatureParticleEffectTrigger;
    }
}
