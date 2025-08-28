using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEAEB24C7B77FC42A, NameHash = 0xA6F502B8)]
    public class TkDynamicPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkRigidBodyComponentData RigidBody;
        [NMS(Index = 0)]
        /* 0x20 */ public TkPhysicsData Data;
        // size: 0x2
        public enum PhysicsSurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        [NMS(Index = 2)]
        /* 0x38 */ public PhysicsSurfacePropertiesEnum PhysicsSurfaceProperties;
        [NMS(Index = 11)]
        /* 0x3C */ public float SimpleCharacterCollisionFwdOffset;
        [NMS(Index = 9)]
        /* 0x40 */ public float SimpleCharacterCollisionHeight;
        [NMS(Index = 10)]
        /* 0x44 */ public float SimpleCharacterCollisionHeightOffset;
        [NMS(Index = 8)]
        /* 0x48 */ public float SimpleCharacterCollisionRadius;
        [NMS(Index = 4)]
        /* 0x4C */ public float SpinOnCreate;
        [NMS(Index = 13)]
        /* 0x50 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 5)]
        /* 0x54 */ public bool Animated;
        [NMS(Index = 3)]
        /* 0x55 */ public bool DisableGravity;
        [NMS(Index = 7)]
        /* 0x56 */ public bool RotateSimpleCharacterCollisionCapsule;
        [NMS(Index = 12)]
        /* 0x57 */ public bool TriggerVolume;
        [NMS(Index = 6)]
        /* 0x58 */ public bool UseSimpleCharacterCollision;
    }
}
