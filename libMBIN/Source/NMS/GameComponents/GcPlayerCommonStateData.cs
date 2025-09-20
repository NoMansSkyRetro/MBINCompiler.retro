using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D270588AC0F62CC, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x34F0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x4EF8 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x50C0 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x5240 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x5250 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x5260 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x5270 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x5278 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x5280 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5300 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5301 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x5302 */ public bool UsesThirdPersonVehicleCam;
    }
}
