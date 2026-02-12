using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEEA384AB277BC520, NameHash = 0xB2405C75)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        [NMS(Index = 4)]
        /* 0x1C */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 1)]
        /* 0x20 */ public TkNavMeshInclusionParams NavMeshInclusion;
        [NMS(Index = 3)]
        /* 0x23 */ public bool AddToWorldImmediately;
        [NMS(Index = 2)]
        /* 0x24 */ public bool AddToWorldOnPrepare;
        [NMS(Index = 10)]
        /* 0x25 */ public bool CameraInvisible;
        [NMS(Index = 6)]
        /* 0x26 */ public bool Climbable;
        [NMS(Index = 8)]
        /* 0x27 */ public bool NoPlayerCollide;
        [NMS(Index = 9)]
        /* 0x28 */ public bool NoTerrainCollide;
        [NMS(Index = 7)]
        /* 0x29 */ public bool NoVehicleCollide;
        [NMS(Index = 5)]
        /* 0x2A */ public bool TriggerVolume;
    }
}
