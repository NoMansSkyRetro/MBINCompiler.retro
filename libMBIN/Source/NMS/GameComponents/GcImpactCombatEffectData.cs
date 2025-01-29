using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3DA7E2B7F19ADD5, NameHash = 0x390217FA)]
    public class GcImpactCombatEffectData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        [NMS(Index = 3)]
        /* 0x4 */ public float CurrentDuration;
        [NMS(Index = 2)]
        /* 0x8 */ public float DamagePerSeccond;
        [NMS(Index = 1)]
        /* 0xC */ public float TotalDuration;
    }
}
