using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCBFED2606B5984E3, NameHash = 0xB2405C75)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        // size: 0x2
        public enum StaticPhysicsTargetNodeEnum : uint {
            Attachment,
            MasterModel,
        }
        [NMS(Index = 2)]
        /* 0x1C */ public StaticPhysicsTargetNodeEnum StaticPhysicsTargetNode;
        [NMS(Index = 5)]
        /* 0x20 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 1)]
        /* 0x24 */ public TkNavMeshInclusionParams NavMeshInclusion;
        [NMS(Index = 4)]
        /* 0x27 */ public bool AddToWorldImmediately;
        [NMS(Index = 3)]
        /* 0x28 */ public bool AddToWorldOnPrepare;
        [NMS(Index = 11)]
        /* 0x29 */ public bool CameraInvisible;
        [NMS(Index = 7)]
        /* 0x2A */ public bool Climbable;
        [NMS(Index = 9)]
        /* 0x2B */ public bool NoPlayerCollide;
        [NMS(Index = 10)]
        /* 0x2C */ public bool NoTerrainCollide;
        [NMS(Index = 8)]
        /* 0x2D */ public bool NoVehicleCollide;
        [NMS(Index = 6)]
        /* 0x2E */ public bool TriggerVolume;
    }
}
