namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x922676C3718BDC65, NameHash = 0x5F03B020)]
    public class GcStatusMessageMissionMarkup : NMSTemplate
    {
        // size: 0x12
        public enum MissionMarkupEnum : uint {
            KillFiend,
            KillPirate,
            KillSentinel,
            KillHazardousPlants,
            KillTraders,
            KillCreatures,
            KillPredators,
            KillDepot,
            KillWorms,
            KillSpookSquids,
            FeedCreature,
            CollectBones,
            CollectScrap,
            Discover,
            CollectSubstanceProduct,
            Build,
            Always,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionMarkupEnum MissionMarkup;
    }
}
