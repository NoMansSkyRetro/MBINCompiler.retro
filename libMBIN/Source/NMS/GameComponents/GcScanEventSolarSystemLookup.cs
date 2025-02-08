using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C65FA5CE638A49C, NameHash = 0x9CE4FFF3)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        [NMS(Index = 36)]
        /* 0x00 */ public NMSString0x20A SamePlanetAsEvent;
        [NMS(Index = 31)]
        /* 0x20 */ public NMSString0x10 NeedsResourceHint;
        [NMS(Index = 38)]
        /* 0x30 */ public NMSString0x10 SystemNeedsResourceHint;
        [NMS(Index = 7)]
        /* 0x40 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 46)]
        /* 0x48 */ public int MinPlanets;
        [NMS(Index = 27)]
        /* 0x4C */ public GcBiomeType NeedsBiomeType;
        [NMS(Index = 37)]
        /* 0x50 */ public int SamePlanetAsSeasonParty;
        [NMS(Index = 6)]
        /* 0x54 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 4)]
        /* 0x58 */ public GcGalaxyStarAnomaly UseAnomaly;
        [NMS(Index = 28)]
        /* 0x5C */ public GcBiomeSubType UseBiomeSubType;
        [NMS(Index = 5)]
        /* 0x60 */ public GcPlayerConflictData UseConflict;
        [NMS(Index = 3)]
        /* 0x64 */ public GcAlienRace UseRace;
        [NMS(Index = 11)]
        /* 0x68 */ public bool AllowedToBePurpleWithoutAccess;
        [NMS(Index = 8)]
        /* 0x69 */ public bool AllowUnsafeMatches;
        [NMS(Index = 23)]
        /* 0x6A */ public bool AnyBiomeNotWeirdOrDead;
        [NMS(Index = 25)]
        /* 0x6B */ public bool AnyInfestedBiome;
        [NMS(Index = 24)]
        /* 0x6C */ public bool AnyRGBBiome;
        [NMS(Index = 30)]
        /* 0x6D */ public bool NeedsAbandonedSystem;
        [NMS(Index = 26)]
        /* 0x6E */ public bool NeedsBiome;
        [NMS(Index = 17)]
        /* 0x6F */ public bool NeedsCorruptSentinelPlanet;
        [NMS(Index = 14)]
        /* 0x70 */ public bool NeedsDeepWaterPlanet;
        [NMS(Index = 29)]
        /* 0x71 */ public bool NeedsEmptySystem;
        [NMS(Index = 21)]
        /* 0x72 */ public bool NeedsExtremeHazardPlanet;
        [NMS(Index = 18)]
        /* 0x73 */ public bool NeedsExtremeSentinelPlanet;
        [NMS(Index = 20)]
        /* 0x74 */ public bool NeedsExtremeWeatherPlanet;
        [NMS(Index = 15)]
        /* 0x75 */ public bool NeedsPrimePlanet;
        [NMS(Index = 16)]
        /* 0x76 */ public bool NeedsSentinels;
        [NMS(Index = 13)]
        /* 0x77 */ public bool NeedsWaterPlanet;
        [NMS(Index = 10)]
        /* 0x78 */ public bool NeverAllowAbandoned;
        [NMS(Index = 9)]
        /* 0x79 */ public bool NeverAllowEmpty;
        [NMS(Index = 19)]
        /* 0x7A */ public bool NeverAllowExtremeSentinelPlanet;
        [NMS(Index = 22)]
        /* 0x7B */ public bool NeverAllowExtremeWeatherPlanet;
        [NMS(Index = 45)]
        /* 0x7C */ public bool NeverAllowGasGiantSystem;
        [NMS(Index = 12)]
        /* 0x7D */ public bool RequireUndiscovered;
        [NMS(Index = 32)]
        /* 0x7E */ public bool SuitableForCreatureDiscovery;
        [NMS(Index = 35)]
        /* 0x7F */ public bool SuitableForCreatureTaming;
        [NMS(Index = 34)]
        /* 0x80 */ public bool SuitableForRobotCreatureDiscovery;
        [NMS(Index = 33)]
        /* 0x81 */ public bool SuitableForWeirdCreatureDiscovery;
        [NMS(Index = 42)]
        /* 0x82 */ public bool SystemNeedsCorruptSentinelPlanet;
        [NMS(Index = 43)]
        /* 0x83 */ public bool SystemNeedsExtremeStormPlanet;
        [NMS(Index = 44)]
        /* 0x84 */ public bool SystemNeedsGasGiant;
        [NMS(Index = 41)]
        /* 0x85 */ public bool SystemNeedsInfestedPlanet;
        [NMS(Index = 39)]
        /* 0x86 */ public bool SystemNeedsWater;
        [NMS(Index = 40)]
        /* 0x87 */ public bool SystemNeedsWeirdPlanet;
        [NMS(Index = 0)]
        /* 0x88 */ public bool UseStarType;
        [NMS(Index = 2)]
        /* 0x89 */ public bool UseTrading;
        [NMS(Index = 1)]
        /* 0x8A */ public bool UseWealth;
    }
}
