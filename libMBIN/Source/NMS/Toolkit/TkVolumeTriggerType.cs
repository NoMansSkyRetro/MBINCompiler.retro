namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB79D26ABD9992981, NameHash = 0xEE0FA479)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // size: 0x16
        public enum VolumeTriggerTypeEnum : uint {
            Open,
            GenericInterior,
            GenericGlassInterior,
            Corridor,
            SmallRoom,
            LargeRoom,
            OpenCovered,
            HazardProtection,
            Dungeon,
            FieldBoundary,
            Custom_Biodome,
            Portal,
            VehicleBoost,
            NexusPlaza,
            NexusCommunityHub,
            NexusHangar,
            RaceObstacle,
            HazardProtectionCold,
            SpaceStorm,
            HazardProtectionNoRecharge,
            HazardProtectionSpook,
            ForceJetpackIgnition,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
