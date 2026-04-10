using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDBB7B253B28EB19A, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x6A88 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x8490 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x8658 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x87D8 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x87E8 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x87F8 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x8808 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x8810 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x8818 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x8898 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x8899 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x889A */ public bool UsesThirdPersonVehicleCam;
    }
}
