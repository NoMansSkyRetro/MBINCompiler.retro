using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CA730CAF21804B1, NameHash = 0x4E404FB0)]
    public class GcScannableComponentData : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public NMSString0x20A FreighterObjectAlreadyUsedLocID;
        [NMS(Index = 19)]
        /* 0x20 */ public NMSString0x10 MissionSurveyId;
        [NMS(Index = 4)]
        /* 0x30 */ public float AlwaysShowRange;
        [NMS(Index = 11)]
        /* 0x34 */ public GcDiscoveryType BinocsDiscoIconOverride;
        [NMS(Index = 3)]
        /* 0x38 */ public float CompassRangeMultiplier;
        [NMS(Index = 10)]
        /* 0x3C */ public GcScannerIconTypes Icon;
        [NMS(Index = 20)]
        /* 0x40 */ public float MinDisplayDistanceOverride;
        // size: 0x6
        public enum ScannableTypeEnum : uint {
            Binoculars,
            BinocularsHotspots,
            Scanner,
            Marker,
            SpaceBattleTarget,
            None,
        }
        [NMS(Index = 12)]
        /* 0x44 */ public ScannableTypeEnum ScannableType;
        [NMS(Index = 0)]
        /* 0x48 */ public float ScanRange;
        [NMS(Index = 2)]
        /* 0x4C */ public float ScanTime;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x20 ScanName;
        [NMS(Index = 17)]
        /* 0x70 */ public bool AllowedToMerge;
        [NMS(Index = 5)]
        /* 0x71 */ public bool CanTagIcon;
        [NMS(Index = 6)]
        /* 0x72 */ public bool ClearTagOnArrival;
        [NMS(Index = 7)]
        /* 0x73 */ public bool DisableIfBuildingPart;
        [NMS(Index = 8)]
        /* 0x74 */ public bool DisableIfInBase;
        [NMS(Index = 13)]
        /* 0x75 */ public bool IsPlacedMarker;
        [NMS(Index = 18)]
        /* 0x76 */ public bool MarkerActiveWithNodeInactive;
        [NMS(Index = 14)]
        /* 0x77 */ public bool ShowInFreighterBranchRoom;
        [NMS(Index = 15)]
        /* 0x78 */ public bool TellPlayerIfFreighterObjectUsed;
        [NMS(Index = 9)]
        /* 0x79 */ public bool UseModelNode;
    }
}
