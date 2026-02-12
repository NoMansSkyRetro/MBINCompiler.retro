using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1239EA6447FC4053, NameHash = 0x537A2B62)]
    public class GcMissionConditionNumPhysicsObjectsInVolume : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 NumIsDiffBetweenMissionStatAndThisStat;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 SubtractThisStatFromNumReq;
        [NMS(Index = 5)]
        /* 0x20 */ public VariableSizeString TextTagForCurrent;
        [NMS(Index = 6)]
        /* 0x30 */ public VariableSizeString TextTagForTarget;
        [NMS(Index = 7)]
        /* 0x40 */ public GcObjectCounterVolumeType CounterVolumeType;
        [NMS(Index = 8)]
        /* 0x44 */ public GcStaticTag ObjectTypeOverride;
        [NMS(Index = 0)]
        /* 0x48 */ public int RequiredNumObjects;
        [NMS(Index = 4)]
        /* 0x4C */ public TkEqualityEnum Test;
        [NMS(Index = 1)]
        /* 0x50 */ public bool TakeNumFromSeasonData;
    }
}
