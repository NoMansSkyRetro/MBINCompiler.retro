using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8672FECAF8256AD, NameHash = 0x9FF55E4C)]
    public class GcMissionConditionWeaponMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerWeapons WeaponMode;
    }
}
