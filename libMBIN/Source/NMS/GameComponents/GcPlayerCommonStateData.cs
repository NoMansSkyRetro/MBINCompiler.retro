using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A21B3B24D86A472, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x34A0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x4EA8 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x5058 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x51D0 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x51E0 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x51F0 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x5200 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x5208 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x5210 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5290 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5291 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x5292 */ public bool UsesThirdPersonVehicleCam;
    }
}
