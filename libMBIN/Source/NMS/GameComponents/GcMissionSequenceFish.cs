using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48CC989022BD316, NameHash = 0xBF805707)]
    public class GcMissionSequenceFish : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcFishData TargetFishInfo;
        [NMS(Index = 17)]
        /* 0x68 */ public VariableSizeString DebugText;
        [NMS(Index = 15)]
        /* 0x78 */ public NMSString0x10 FormatStatIntoText;
        [NMS(Index = 0)]
        /* 0x88 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x98 */ public VariableSizeString MessageAvailableNearby;
        [NMS(Index = 4)]
        /* 0xA8 */ public VariableSizeString MessageNoFishLaserEquipped;
        [NMS(Index = 3)]
        /* 0xB8 */ public VariableSizeString MessageNoFishLaserInstalled;
        [NMS(Index = 2)]
        /* 0xC8 */ public VariableSizeString MessageNoneInSystem;
        [NMS(Index = 5)]
        /* 0xD8 */ public int Amount;
        [NMS(Index = 12)]
        /* 0xDC */ public float DepthToFormatIntoText;
        [NMS(Index = 6)]
        /* 0xE0 */ public bool FromNow;
        [NMS(Index = 16)]
        /* 0xE1 */ public bool Multiplayer;
        [NMS(Index = 14)]
        /* 0xE2 */ public bool NeverCompleteSequence;
        [NMS(Index = 8)]
        /* 0xE3 */ public bool QualityTestIsEqualOrGreater;
        [NMS(Index = 9)]
        /* 0xE4 */ public bool SizeTestIsEqualOrGreater;
        [NMS(Index = 10)]
        /* 0xE5 */ public bool TakeAmountFromDefaultNumber;
        [NMS(Index = 11)]
        /* 0xE6 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 13)]
        /* 0xE7 */ public bool TakeDepthFromSeasonData;
    }
}
