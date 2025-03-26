namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF0615F6F1831437, NameHash = 0xA50EBF75)]
    public class GcSentinelTypes : NMSTemplate
    {
        // size: 0xD
        public enum SentinelTypeEnum : uint {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            SpiderQuad,
            SpiderQuadMini,
            Mech,
            Walker,
            FriendlyDrone,
            StoneMech,
            StoneFloater,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelTypeEnum SentinelType;
    }
}
