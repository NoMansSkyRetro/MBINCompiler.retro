using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA0AC732D03AC6BAB, NameHash = 0xA6F502B8)]
    public class TkDynamicPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkRigidBodyComponentData RigidBody;
        [NMS(Index = 0)]
        /* 0x28 */ public TkPhysicsData Data;
        // size: 0x2
        public enum PhysicsSurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        [NMS(Index = 2)]
        /* 0x44 */ public PhysicsSurfacePropertiesEnum PhysicsSurfaceProperties;
        [NMS(Index = 11)]
        /* 0x48 */ public float SimpleCharacterCollisionFwdOffset;
        [NMS(Index = 9)]
        /* 0x4C */ public float SimpleCharacterCollisionHeight;
        [NMS(Index = 10)]
        /* 0x50 */ public float SimpleCharacterCollisionHeightOffset;
        [NMS(Index = 8)]
        /* 0x54 */ public float SimpleCharacterCollisionRadius;
        [NMS(Index = 4)]
        /* 0x58 */ public float SpinOnCreate;
        [NMS(Index = 5)]
        /* 0x5C */ public bool Animated;
        [NMS(Index = 3)]
        /* 0x5D */ public bool DisableGravity;
        [NMS(Index = 7)]
        /* 0x5E */ public bool RotateSimpleCharacterCollisionCapsule;
        [NMS(Index = 6)]
        /* 0x5F */ public bool UseSimpleCharacterCollision;
    }
}
