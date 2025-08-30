using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x213BA32C22653B12, NameHash = 0xF90BB3)]
    public class TkPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        // size: 0x3
        public enum ModelOwnershipEnum : uint {
            Model,
            MasterModel,
            None,
        }
        [NMS(Index = 4)]
        /* 0x18 */ public ModelOwnershipEnum ModelOwnership;
        [NMS(Index = 33)]
        /* 0x1C */ public float SimpleCharacterCollisionFwdOffset;
        [NMS(Index = 31)]
        /* 0x20 */ public float SimpleCharacterCollisionHeight;
        [NMS(Index = 32)]
        /* 0x24 */ public float SimpleCharacterCollisionHeightOffset;
        [NMS(Index = 30)]
        /* 0x28 */ public float SimpleCharacterCollisionRadius;
        [NMS(Index = 22)]
        /* 0x2C */ public float SpinOnCreate;
        // size: 0x2
        public enum SurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        [NMS(Index = 3)]
        /* 0x30 */ public SurfacePropertiesEnum SurfaceProperties;
        [NMS(Index = 2)]
        /* 0x34 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 24)]
        /* 0x38 */ public bool AllowedDefaultCollision;
        [NMS(Index = 18)]
        /* 0x39 */ public bool AllowTeleporter;
        [NMS(Index = 25)]
        /* 0x3A */ public bool Animated;
        [NMS(Index = 15)]
        /* 0x3B */ public bool BlocksInteract;
        [NMS(Index = 19)]
        /* 0x3C */ public bool BlockTeleporter;
        [NMS(Index = 16)]
        /* 0x3D */ public bool CameraInvisible;
        [NMS(Index = 20)]
        /* 0x3E */ public bool CanBeTooSteepForTeleporter;
        [NMS(Index = 5)]
        /* 0x3F */ public bool Climbable;
        [NMS(Index = 21)]
        /* 0x40 */ public bool DisableGravity;
        [NMS(Index = 7)]
        /* 0x41 */ public bool Floor;
        [NMS(Index = 14)]
        /* 0x42 */ public bool IgnoreAllCollisions;
        [NMS(Index = 8)]
        /* 0x43 */ public bool IgnoreModelOwner;
        [NMS(Index = 17)]
        /* 0x44 */ public bool InvisibleForInteraction;
        [NMS(Index = 27)]
        /* 0x45 */ public bool IsTransporter;
        [NMS(Index = 13)]
        /* 0x46 */ public bool NoFallDamage;
        [NMS(Index = 12)]
        /* 0x47 */ public bool NoFireCollide;
        [NMS(Index = 10)]
        /* 0x48 */ public bool NoPlayerCollide;
        [NMS(Index = 11)]
        /* 0x49 */ public bool NoTerrainCollide;
        [NMS(Index = 9)]
        /* 0x4A */ public bool NoVehicleCollide;
        [NMS(Index = 29)]
        /* 0x4B */ public bool RotateSimpleCharacterCollisionCapsule;
        [NMS(Index = 23)]
        /* 0x4C */ public bool ScaleAffectsMass;
        [NMS(Index = 1)]
        /* 0x4D */ public bool TriggerVolume;
        [NMS(Index = 26)]
        /* 0x4E */ public bool UseBasePartOptimisation;
        [NMS(Index = 28)]
        /* 0x4F */ public bool UseSimpleCharacterCollision;
        [NMS(Index = 6)]
        /* 0x50 */ public bool Walkable;
    }
}
