using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B5FBC73FF6C4DCE, NameHash = 0x4E404FB0)]
    public class GcScannableComponentData : NMSTemplate
    {
        [NMS(Index = 17)]
        /* 0x00 */ public NMSString0x20A FreighterObjectAlreadyUsedLocID;
        [NMS(Index = 21)]
        /* 0x20 */ public List<NMSString0x10> ValidMissionSurveyIds;
        [NMS(Index = 4)]
        /* 0x30 */ public float AlwaysShowRange;
        [NMS(Index = 12)]
        /* 0x34 */ public GcDiscoveryType BinocsDiscoIconOverride;
        [NMS(Index = 3)]
        /* 0x38 */ public float CompassRangeMultiplier;
        [NMS(Index = 11)]
        /* 0x3C */ public GcScannerIconTypes Icon;
        [NMS(Index = 23)]
        /* 0x40 */ public float MarkerOffsetOverride;
        [NMS(Index = 22)]
        /* 0x44 */ public float MinDisplayDistanceOverride;
        // size: 0x6
        public enum ScannableTypeEnum : uint {
            Binoculars,
            BinocularsHotspots,
            Scanner,
            Marker,
            SpaceBattleTarget,
            None,
        }
        [NMS(Index = 13)]
        /* 0x48 */ public ScannableTypeEnum ScannableType;
        [NMS(Index = 0)]
        /* 0x4C */ public float ScanRange;
        [NMS(Index = 2)]
        /* 0x50 */ public float ScanTime;
        [NMS(Index = 1)]
        /* 0x54 */ public NMSString0x20 ScanName;
        [NMS(Index = 19)]
        /* 0x74 */ public bool AllowedToMerge;
        [NMS(Index = 6)]
        /* 0x75 */ public bool CanTagIcon;
        [NMS(Index = 7)]
        /* 0x76 */ public bool ClearTagOnArrival;
        [NMS(Index = 8)]
        /* 0x77 */ public bool DisableIfBuildingPart;
        [NMS(Index = 9)]
        /* 0x78 */ public bool DisableIfInBase;
        [NMS(Index = 24)]
        /* 0x79 */ public bool ForceCompassMarkerOnForScannerIcon;
        [NMS(Index = 18)]
        /* 0x7A */ public bool GetIconAndNameFromSettlementBuilding;
        [NMS(Index = 5)]
        /* 0x7B */ public bool HideCompassInAlwaysShowRange;
        [NMS(Index = 14)]
        /* 0x7C */ public bool IsPlacedMarker;
        [NMS(Index = 20)]
        /* 0x7D */ public bool MarkerActiveWithNodeInactive;
        [NMS(Index = 15)]
        /* 0x7E */ public bool ShowInFreighterBranchRoom;
        [NMS(Index = 16)]
        /* 0x7F */ public bool TellPlayerIfFreighterObjectUsed;
        [NMS(Index = 10)]
        /* 0x80 */ public bool UseModelNode;
    }
}
