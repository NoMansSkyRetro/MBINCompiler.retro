namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9DEE4165BD90EC1, NameHash = 0x611210D4)]
    public class GcSentinelMechWeaponMode : NMSTemplate
    {
        // size: 0x3
        public enum SentinelMechWeaponModeEnum : uint {
            Gun,
            Canon,
            Flamethrower,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelMechWeaponModeEnum SentinelMechWeaponMode;
    }
}
