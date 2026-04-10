using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6B644731D859D1A, NameHash = 0x9CE4FFF3)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        [NMS(Index = 38)]
        /* 0x00 */ public NMSString0x20A SamePlanetAsEvent;
        [NMS(Index = 40)]
        /* 0x20 */ public List<NMSString0x20A> ExcludePlanetsWithEvents;
        [NMS(Index = 32)]
        /* 0x30 */ public NMSString0x10 NeedsResourceHint;
        [NMS(Index = 37)]
        /* 0x40 */ public NMSString0x10 NeedsSpecificCreature;
        [NMS(Index = 41)]
        /* 0x50 */ public NMSString0x10 SystemNeedsResourceHint;
        [NMS(Index = 7)]
        /* 0x60 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 51)]
        /* 0x68 */ public int MinPlanets;
        [NMS(Index = 28)]
        /* 0x6C */ public GcBiomeType NeedsBiomeType;
        [NMS(Index = 39)]
        /* 0x70 */ public int SamePlanetAsSeasonParty;
        [NMS(Index = 6)]
        /* 0x74 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 4)]
        /* 0x78 */ public GcGalaxyStarAnomaly UseAnomaly;
        [NMS(Index = 29)]
        /* 0x7C */ public GcBiomeSubType UseBiomeSubType;
        [NMS(Index = 5)]
        /* 0x80 */ public GcPlayerConflictData UseConflict;
        [NMS(Index = 3)]
        /* 0x84 */ public GcAlienRace UseRace;
        [NMS(Index = 11)]
        /* 0x88 */ public bool AllowedToBePurpleWithoutAccess;
        [NMS(Index = 8)]
        /* 0x89 */ public bool AllowUnsafeMatches;
        [NMS(Index = 13)]
        /* 0x8A */ public bool AlwaysAvailableInPirateStations;
        [NMS(Index = 24)]
        /* 0x8B */ public bool AnyBiomeNotWeirdOrDead;
        [NMS(Index = 26)]
        /* 0x8C */ public bool AnyInfestedBiome;
        [NMS(Index = 25)]
        /* 0x8D */ public bool AnyRGBBiome;
        [NMS(Index = 31)]
        /* 0x8E */ public bool NeedsAbandonedSystem;
        [NMS(Index = 27)]
        /* 0x8F */ public bool NeedsBiome;
        [NMS(Index = 18)]
        /* 0x90 */ public bool NeedsCorruptSentinelPlanet;
        [NMS(Index = 15)]
        /* 0x91 */ public bool NeedsDeepWaterPlanet;
        [NMS(Index = 30)]
        /* 0x92 */ public bool NeedsEmptySystem;
        [NMS(Index = 22)]
        /* 0x93 */ public bool NeedsExtremeHazardPlanet;
        [NMS(Index = 19)]
        /* 0x94 */ public bool NeedsExtremeSentinelPlanet;
        [NMS(Index = 21)]
        /* 0x95 */ public bool NeedsExtremeWeatherPlanet;
        [NMS(Index = 16)]
        /* 0x96 */ public bool NeedsPrimePlanet;
        [NMS(Index = 17)]
        /* 0x97 */ public bool NeedsSentinels;
        [NMS(Index = 14)]
        /* 0x98 */ public bool NeedsWaterPlanet;
        [NMS(Index = 10)]
        /* 0x99 */ public bool NeverAllowAbandoned;
        [NMS(Index = 9)]
        /* 0x9A */ public bool NeverAllowEmpty;
        [NMS(Index = 20)]
        /* 0x9B */ public bool NeverAllowExtremeSentinelPlanet;
        [NMS(Index = 23)]
        /* 0x9C */ public bool NeverAllowExtremeWeatherPlanet;
        [NMS(Index = 50)]
        /* 0x9D */ public bool NeverAllowGasGiantSystem;
        [NMS(Index = 12)]
        /* 0x9E */ public bool RequireUndiscovered;
        [NMS(Index = 33)]
        /* 0x9F */ public bool SuitableForCreatureDiscovery;
        [NMS(Index = 36)]
        /* 0xA0 */ public bool SuitableForCreatureTaming;
        [NMS(Index = 35)]
        /* 0xA1 */ public bool SuitableForRobotCreatureDiscovery;
        [NMS(Index = 34)]
        /* 0xA2 */ public bool SuitableForWeirdCreatureDiscovery;
        [NMS(Index = 46)]
        /* 0xA3 */ public bool SystemNeedsCorruptSentinelPlanet;
        [NMS(Index = 47)]
        /* 0xA4 */ public bool SystemNeedsExtremeStormPlanet;
        [NMS(Index = 48)]
        /* 0xA5 */ public bool SystemNeedsGasGiant;
        [NMS(Index = 44)]
        /* 0xA6 */ public bool SystemNeedsInfestedPlanet;
        [NMS(Index = 49)]
        /* 0xA7 */ public bool SystemNeedsNonGasGiant;
        [NMS(Index = 45)]
        /* 0xA8 */ public bool SystemNeedsRelicPlanet;
        [NMS(Index = 42)]
        /* 0xA9 */ public bool SystemNeedsWater;
        [NMS(Index = 43)]
        /* 0xAA */ public bool SystemNeedsWeirdPlanet;
        [NMS(Index = 0)]
        /* 0xAB */ public bool UseStarType;
        [NMS(Index = 2)]
        /* 0xAC */ public bool UseTrading;
        [NMS(Index = 1)]
        /* 0xAD */ public bool UseWealth;
    }
}
