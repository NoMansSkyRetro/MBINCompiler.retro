using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCCFA0C9FDCDF7D6, NameHash = 0x37EBD7AD)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcPulseEncounterSpawnObject Encounter;
        [NMS(Index = 1)]
        /* 0x70 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0xA0 */ public float DespawnDistance;
        [NMS(Index = 5)]
        /* 0xA4 */ public float MinDuration;
        [NMS(Index = 2)]
        /* 0xA8 */ public float SelectionWeighting;
        [NMS(Index = 3)]
        /* 0xAC */ public float SpawnChance;
        [NMS(Index = 4)]
        /* 0xB0 */ public float SpawnDistance;
    }
}
