using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5BD0AF2C88C8AD3, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x3538 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x4F40 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x5108 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x5288 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x5298 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x52A8 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x52B8 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x52C0 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x52C8 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5348 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5349 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x534A */ public bool UsesThirdPersonVehicleCam;
    }
}
