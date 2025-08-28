using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDD6C6AE3503FD4B6, NameHash = 0xFA1C5236)]
    public class TkParticleData : NMSTemplate
    {
        [NMS(Index = 38)]
        /* 0x000 */ public TkEmitterRotation SecondRotationInfo;
        [NMS(Index = 54)]
        /* 0x050 */ public Colour ColourEnd;
        [NMS(Index = 53)]
        /* 0x060 */ public Colour ColourMiddle;
        [NMS(Index = 52)]
        /* 0x070 */ public Colour ColourStart;
        [NMS(Index = 21)]
        /* 0x080 */ public Vector3f EmitterDirection;
        [NMS(Index = 46)]
        /* 0x090 */ public Vector3f RotateAroundEmitterAxis;
        [NMS(Index = 36)]
        /* 0x0A0 */ public Vector3f RotationAxis;
        [NMS(Index = 40)]
        /* 0x0B0 */ public Vector3f RotationPivot;
        [NMS(Index = 30)]
        /* 0x0C0 */ public Vector3f SpawnOffsetParams;
        [NMS(Index = 31)]
        /* 0x0D0 */ public TkParticleSize ParticleSize;
        [NMS(Index = 10)]
        /* 0x1E0 */ public TkParticleBurstData BurstData;
        [NMS(Index = 55)]
        /* 0x258 */ public TkEmitterFloatProperty AlphaThreshold;
        [NMS(Index = 11)]
        /* 0x290 */ public TkEmitterFloatProperty EmissionRate;
        [NMS(Index = 15)]
        /* 0x2C8 */ public TkEmitterFloatProperty EmitterLife;
        [NMS(Index = 24)]
        /* 0x300 */ public TkEmitterFloatProperty ParticleDamping;
        [NMS(Index = 25)]
        /* 0x338 */ public TkEmitterFloatProperty ParticleDrag;
        [NMS(Index = 23)]
        /* 0x370 */ public TkEmitterFloatProperty ParticleGravity;
        [NMS(Index = 14)]
        /* 0x3A8 */ public TkEmitterFloatProperty ParticleLife;
        [NMS(Index = 32)]
        /* 0x3E0 */ public TkEmitterFloatProperty ParticleSizeY;
        [NMS(Index = 22)]
        /* 0x418 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        [NMS(Index = 35)]
        /* 0x450 */ public TkEmitterFloatProperty Rotation;
        [NMS(Index = 1, MxmlName = "3DGeom")]
        /* 0x488 */ public VariableSizeString _3DGeom;
        [NMS(Index = 3)]
        /* 0x498 */ public VariableSizeString TrailPath;
        [NMS(Index = 58)]
        /* 0x4A8 */ public NMSString0x10 UserColour;
        [NMS(Index = 66)]
        /* 0x4B8 */ public TkEmitterWindDrift WindDrift;
        [NMS(Index = 39, MxmlName = "Billboard Alignment")]
        /* 0x4D4 */ public TkEmitterBillboardAlignment BillboardAlignment;
        [NMS(Index = 64)]
        /* 0x4DC */ public TkFloatRange CameraDistanceFade;
        [NMS(Index = 13)]
        /* 0x4E4 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        [NMS(Index = 33)]
        /* 0x4EC */ public AlignmentEnum Alignment;
        [NMS(Index = 51)]
        /* 0x4F0 */ public float AlphaVariance;
        [NMS(Index = 6)]
        /* 0x4F4 */ public uint AudioEvent;
        [NMS(Index = 12)]
        /* 0x4F8 */ public float Delay;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        [NMS(Index = 26)]
        /* 0x4FC */ public DragTypeEnum DragType;
        [NMS(Index = 16)]
        /* 0x500 */ public float EmitterMidLifeRatio;
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        [NMS(Index = 0)]
        /* 0x504 */ public EmitterQualityLevelEnum EmitterQualityLevel;
        [NMS(Index = 19)]
        /* 0x508 */ public float EmitterSpreadAngle;
        [NMS(Index = 20)]
        /* 0x50C */ public float EmitterSpreadAngleMin;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        [NMS(Index = 47)]
        /* 0x510 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        [NMS(Index = 48)]
        /* 0x514 */ public float HueVariance;
        [NMS(Index = 50)]
        /* 0x518 */ public float LightnessVariance;
        [NMS(Index = 65)]
        /* 0x51C */ public float LimitLifetimeOnMove;
        [NMS(Index = 9)]
        /* 0x520 */ public int MaxCount;
        [NMS(Index = 60)]
        /* 0x524 */ public float MaxRenderCameraHeight;
        [NMS(Index = 59)]
        /* 0x528 */ public float MaxRenderDistance;
        [NMS(Index = 61)]
        /* 0x52C */ public float MaxSpawnDistance;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        [NMS(Index = 56)]
        /* 0x530 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        [NMS(Index = 45)]
        /* 0x534 */ public float RotateAroundEmitter;
        [NMS(Index = 49)]
        /* 0x538 */ public float SaturationVariance;
        [NMS(Index = 62)]
        /* 0x53C */ public float SoftFadeStrength;
        // size: 0x6
        public enum SpawnOffsetTypeEnum : uint {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point,
        }
        [NMS(Index = 29)]
        /* 0x540 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        [NMS(Index = 28)]
        /* 0x544 */ public float StartOffset;
        [NMS(Index = 34)]
        /* 0x548 */ public float StartRotationVariation;
        [NMS(Index = 63)]
        /* 0x54C */ public float SurfaceDistanceFadeStrength;
        [NMS(Index = 44)]
        /* 0x550 */ public float TrackEmitterPosition;
        [NMS(Index = 4)]
        /* 0x554 */ public float TrailRatio;
        [NMS(Index = 41, MxmlName = "U Coordinate")]
        /* 0x558 */ public TkCoordinateOrientation UCoordinate;
        [NMS(Index = 42, MxmlName = "V Coordinate")]
        /* 0x55C */ public TkCoordinateOrientation VCoordinate;
        [NMS(Index = 27)]
        /* 0x560 */ public float Variation;
        [NMS(Index = 43)]
        /* 0x564 */ public float VelocityInheritance;
        [NMS(Index = 17)]
        /* 0x568 */ public TkCurveType EmitterLifeCurve1;
        [NMS(Index = 18)]
        /* 0x569 */ public TkCurveType EmitterLifeCurve2;
        [NMS(Index = 37)]
        /* 0x56A */ public bool EnableSecondRotation;
        [NMS(Index = 57)]
        /* 0x56B */ public bool FadeRefractionsAtScreenEdge;
        [NMS(Index = 2)]
        /* 0x56C */ public bool GPURender;
        [NMS(Index = 8)]
        /* 0x56D */ public bool Oneshot;
        [NMS(Index = 7)]
        /* 0x56E */ public bool StartEnabled;
        [NMS(Index = 5)]
        /* 0x56F */ public bool TrailIsRibbon;
    }
}
