namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9198DD8B0DF0C00, NameHash = 0x42E551BD)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0x17
        public enum MissionTypeEnum : uint {
            SpaceCombat,
            GroundCombat,
            Research,
            MissingPerson,
            Repair,
            Cargo,
            Piracy,
            Photo,
            Feeding,
            Planting,
            Construction,
            LocalCorrupted,
            LocalCorruptedCombat,
            LocalSalvage,
            LocalBiomePlants,
            LocalExtreme,
            LocalBones,
            LocalInfested,
            LocalPlanetaryPirates,
            LocalPredators,
            LocalSentinels,
            BuildersLanguage,
            Fishing,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionTypeEnum MissionType;
    }
}
