using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1389D546F6113B3, NameHash = 0x17A032B6)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x0000 */ public GcPlanetColourData Colours;
        [NMS(Index = 12)]
        /* 0x1C00 */ public GcPlanetWeatherData Weather;
        [NMS(Index = 11, Size = 0x17)]
        /* 0x1D80 */ public Colour[] TileColours;
        [NMS(Index = 25)]
        /* 0x1EF0 */ public GcPlanetRingData Rings;
        [NMS(Index = 16)]
        /* 0x1F50 */ public TkVoxelGeneratorData Terrain;
        [NMS(Index = 22)]
        /* 0x30A0 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Index = 19)]
        /* 0x31F8 */ public GcEnvironmentSpawnData SpawnData;
        [NMS(Index = 21)]
        /* 0x3258 */ public GcPlanetBuildingData BuildingData;
        [NMS(Index = 13)]
        /* 0x32A0 */ public GcPlanetCloudProperties Clouds;
        [NMS(Index = 6)]
        /* 0x32E8 */ public NMSString0x10 CommonSubstanceID;
        [NMS(Index = 9)]
        /* 0x32F8 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        [NMS(Index = 8)]
        /* 0x3308 */ public NMSString0x10 RareSubstanceID;
        [NMS(Index = 15)]
        /* 0x3318 */ public VariableSizeString TerrainFile;
        [NMS(Index = 18)]
        /* 0x3328 */ public List<int> TileTypeIndices;
        [NMS(Index = 7)]
        /* 0x3338 */ public NMSString0x10 UncommonSubstanceID;
        [NMS(Index = 3)]
        /* 0x3348 */ public GcPlanetHazardData Hazard;
        [NMS(Index = 23, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x33C0 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        [NMS(Index = 14)]
        /* 0x3420 */ public GcPlanetWaterData Water;
        [NMS(Index = 5)]
        /* 0x3430 */ public GcBuildingDensityLevels BuildingLevel;
        [NMS(Index = 2)]
        /* 0x3434 */ public GcPlanetLife CreatureLife;
        [NMS(Index = 29)]
        /* 0x3438 */ public float FuelMultiplier;
        [NMS(Index = 20)]
        /* 0x343C */ public GcAlienRace InhabitingRace;
        [NMS(Index = 1)]
        /* 0x3440 */ public GcPlanetLife Life;
        [NMS(Index = 30)]
        /* 0x3444 */ public int PlanetIndex;
        // size: 0x2
        public enum ResourceLevelEnum : uint {
            Low,
            High,
        }
        [NMS(Index = 4)]
        /* 0x3448 */ public ResourceLevelEnum ResourceLevel;
        [NMS(Index = 17)]
        /* 0x344C */ public int TileTypeSet;
        [NMS(Index = 24)]
        /* 0x3450 */ public GcPlanetInfo PlanetInfo;
        [NMS(Index = 0)]
        /* 0x3956 */ public NMSString0x80 Name;
        [NMS(Index = 27)]
        /* 0x39D6 */ public bool InAbandonedSystem;
        [NMS(Index = 26)]
        /* 0x39D7 */ public bool InEmptySystem;
        [NMS(Index = 28)]
        /* 0x39D8 */ public bool InGasGiantSystem;
    }
}
