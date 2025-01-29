using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE4484A7015AEB26, NameHash = 0x8710D808)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Index = 19)]
        /* 0x00 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;
        [NMS(Index = 13)]
        /* 0x10 */ public List<int> ForceOnDuringSeasons;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 15, Size = 0x20, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x30 */ public float[] SubBiomeProbability;
        [NMS(Index = 18)]
        /* 0xB0 */ public int MaxFilesToChoose;
        [NMS(Index = 17)]
        /* 0xB4 */ public int MinFilesToChoose;
        [NMS(Index = 14)]
        /* 0xB8 */ public GcBiomeType OnlyOnBiome;
        [NMS(Index = 16)]
        /* 0xBC */ public float ProbabilityOfBeingActive;
        [NMS(Index = 12)]
        /* 0xC0 */ public bool ForceOnSeasonStart;
        [NMS(Index = 9)]
        /* 0xC1 */ public bool NotOnDeadPlanets;
        [NMS(Index = 6)]
        /* 0xC2 */ public bool NotOnExtremePlanets;
        [NMS(Index = 10)]
        /* 0xC3 */ public bool NotOnGasGiant;
        [NMS(Index = 11)]
        /* 0xC4 */ public bool NotOnInfested;
        [NMS(Index = 7)]
        /* 0xC5 */ public bool NotOnStartPlanets;
        [NMS(Index = 8)]
        /* 0xC6 */ public bool NotOnWeirdPlanets;
        [NMS(Index = 3)]
        /* 0xC7 */ public bool OnlyOnCorruptSentinels;
        [NMS(Index = 4)]
        /* 0xC8 */ public bool OnlyOnDeepWater;
        [NMS(Index = 2)]
        /* 0xC9 */ public bool OnlyOnExtremeSentinels;
        [NMS(Index = 1)]
        /* 0xCA */ public bool OnlyOnExtremeWeather;
        [NMS(Index = 5)]
        /* 0xCB */ public bool OnlyOnInfested;
    }
}
