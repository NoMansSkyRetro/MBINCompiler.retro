namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x909D75A18122D8B9, NameHash = 0xD22ECCA9)]
    public class GcEncounterType : NMSTemplate
    {
        // size: 0x8
        public enum EncounterTypeEnum : uint {
            FactoryGuards,
            HarvesterGuards,
            ScrapHeap,
            Reward,
            CorruptedDroneInteract,
            GroundWorms,
            DroneHiveGuards,
            CorruptDronePillar,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EncounterTypeEnum EncounterType;
    }
}
