using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCB7C5AAC25DEB107, NameHash = 0xB2405C75)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        [NMS(Index = 1)]
        /* 0x18 */ public TkNavMeshInclusionParams NavMeshInclusion;
        // size: 0x2
        public enum StaticPhysicsTargetNodeEnum : uint {
            Attachment,
            MasterModel,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public StaticPhysicsTargetNodeEnum StaticPhysicsTargetNode;
        [NMS(Index = 5)]
        /* 0x24 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 4)]
        /* 0x28 */ public bool AddToWorldImmediately;
        [NMS(Index = 3)]
        /* 0x29 */ public bool AddToWorldOnPrepare;
        [NMS(Index = 11)]
        /* 0x2A */ public bool CameraInvisible;
        [NMS(Index = 7)]
        /* 0x2B */ public bool Climbable;
        [NMS(Index = 9)]
        /* 0x2C */ public bool NoPlayerCollide;
        [NMS(Index = 10)]
        /* 0x2D */ public bool NoTerrainCollide;
        [NMS(Index = 8)]
        /* 0x2E */ public bool NoVehicleCollide;
        [NMS(Index = 6)]
        /* 0x2F */ public bool TriggerVolume;
    }
}
