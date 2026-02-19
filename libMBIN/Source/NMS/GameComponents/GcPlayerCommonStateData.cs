using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D376B75D197F3C4, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x3608 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x5010 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x51D8 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x5358 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x5368 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x5378 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x5388 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x5390 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x5398 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5418 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5419 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x541A */ public bool UsesThirdPersonVehicleCam;
    }
}
