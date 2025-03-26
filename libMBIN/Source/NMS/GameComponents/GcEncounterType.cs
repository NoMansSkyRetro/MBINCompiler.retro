namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x468DD0CD864C98C5, NameHash = 0xD22ECCA9)]
    public class GcEncounterType : NMSTemplate
    {
        // size: 0x9
        public enum EncounterTypeEnum : uint {
            FactoryGuards,
            HarvesterGuards,
            ScrapHeap,
            Reward,
            CorruptedDroneInteract,
            GroundWorms,
            DroneHiveGuards,
            CorruptDronePillar,
            Fossil,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EncounterTypeEnum EncounterType;
    }
}
