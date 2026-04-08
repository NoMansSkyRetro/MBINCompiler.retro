using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C9D70319BB52022, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x6128 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x7B30 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x7CF8 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x7E78 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x7E88 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x7E98 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x7EA8 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x7EB0 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x7EB8 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x7F38 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x7F39 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x7F3A */ public bool UsesThirdPersonVehicleCam;
    }
}
