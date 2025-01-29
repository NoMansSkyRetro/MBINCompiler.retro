namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4069CEA2F4EE381, NameHash = 0xA50EBF75)]
    public class GcSentinelTypes : NMSTemplate
    {
        // size: 0xB
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelTypeEnum SentinelType;
    }
}
