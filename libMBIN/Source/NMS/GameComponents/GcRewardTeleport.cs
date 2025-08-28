namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0A9FF622A2126EA, NameHash = 0x3C426079)]
    public class GcRewardTeleport : NMSTemplate
    {
        // size: 0x4
        public enum TeleportRewardTypeEnum : uint {
            None,
            ToBase,
            Station,
            Atlas,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TeleportRewardTypeEnum TeleportRewardType;
    }
}
