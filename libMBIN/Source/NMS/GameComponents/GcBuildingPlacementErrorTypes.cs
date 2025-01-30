namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8217EA84DA04131, NameHash = 0x8CD019E0)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // size: 0x17
        public enum InvalidPlacementReasonEnum : uint {
            Offline,
            InvalidBiome,
            InvalidAboveWater,
            InvalidUnderwater,
            PlanetLimitReached,
            BaseLimitReached,
            RegionLimitReached,
            InvalidMaxBasesReached,
            InvalidOverlappingAnyBase,
            InvalidOverlappingSettlement,
            InvalidOverlappingBase,
            OutOfBaseRange,
            OutOfConnectionRange,
            LinkGridMismatch,
            InsufficientResources,
            ComplexityLimitReached,
            SubstanceOnly,
            InvalidPosition,
            InvalidSnap,
            MustPlaceOnTerrain,
            Collision,
            ShipInside,
            PlayerInside,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
