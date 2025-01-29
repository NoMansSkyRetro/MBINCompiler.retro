using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFFDB689B82866ABD, NameHash = 0xFA1C5236)]
    public class TkParticleData : NMSTemplate
    {
        [NMS(Index = 51)]
        /* 0x000 */ public Colour ColourEnd;
        [NMS(Index = 50)]
        /* 0x010 */ public Colour ColourMiddle;
        [NMS(Index = 49)]
        /* 0x020 */ public Colour ColourStart;
        [NMS(Index = 20)]
        /* 0x030 */ public Vector3f EmitterDirection;
        [NMS(Index = 43)]
        /* 0x040 */ public Vector3f RotateAroundEmitterAxis;
        [NMS(Index = 34)]
        /* 0x050 */ public Vector3f RotationAxis;
        [NMS(Index = 37)]
        /* 0x060 */ public Vector3f RotationPivot;
        [NMS(Index = 29)]
        /* 0x070 */ public Vector3f SpawnOffsetParams;
        [NMS(Index = 30)]
        /* 0x080 */ public TkParticleSize ParticleSize;
        [NMS(Index = 9)]
        /* 0x190 */ public TkParticleBurstData BurstData;
        [NMS(Index = 52)]
        /* 0x208 */ public TkEmitterFloatProperty AlphaThreshold;
        [NMS(Index = 10)]
        /* 0x240 */ public TkEmitterFloatProperty EmissionRate;
        [NMS(Index = 14)]
        /* 0x278 */ public TkEmitterFloatProperty EmitterLife;
        [NMS(Index = 23)]
        /* 0x2B0 */ public TkEmitterFloatProperty ParticleDamping;
        [NMS(Index = 24)]
        /* 0x2E8 */ public TkEmitterFloatProperty ParticleDrag;
        [NMS(Index = 22)]
        /* 0x320 */ public TkEmitterFloatProperty ParticleGravity;
        [NMS(Index = 13)]
        /* 0x358 */ public TkEmitterFloatProperty ParticleLife;
        [NMS(Index = 31)]
        /* 0x390 */ public TkEmitterFloatProperty ParticleSizeY;
        [NMS(Index = 21)]
        /* 0x3C8 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        [NMS(Index = 33)]
        /* 0x400 */ public TkEmitterFloatProperty Rotation;
        [NMS(Index = 1)]
        /* 0x438 */ public VariableSizeString _3DGeom;
        [NMS(Index = 2)]
        /* 0x448 */ public VariableSizeString TrailPath;
        [NMS(Index = 55)]
        /* 0x458 */ public NMSString0x10 UserColour;
        [NMS(Index = 63)]
        /* 0x468 */ public TkEmitterWindDrift WindDrift;
        [NMS(Index = 36, MxmlName = "Billboard Alignment")]
        /* 0x484 */ public TkEmitterBillboardAlignment BillboardAlignment;
        [NMS(Index = 61)]
        /* 0x48C */ public TkFloatRange CameraDistanceFade;
        [NMS(Index = 12)]
        /* 0x494 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        [NMS(Index = 35)]
        /* 0x49C */ public AlignmentEnum Alignment;
        [NMS(Index = 48)]
        /* 0x4A0 */ public float AlphaVariance;
        [NMS(Index = 5)]
        /* 0x4A4 */ public uint AudioEvent;
        [NMS(Index = 11)]
        /* 0x4A8 */ public float Delay;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        [NMS(Index = 25)]
        /* 0x4AC */ public DragTypeEnum DragType;
        [NMS(Index = 15)]
        /* 0x4B0 */ public float EmitterMidLifeRatio;
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        [NMS(Index = 0)]
        /* 0x4B4 */ public EmitterQualityLevelEnum EmitterQualityLevel;
        [NMS(Index = 18)]
        /* 0x4B8 */ public float EmitterSpreadAngle;
        [NMS(Index = 19)]
        /* 0x4BC */ public float EmitterSpreadAngleMin;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        [NMS(Index = 44)]
        /* 0x4C0 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        [NMS(Index = 45)]
        /* 0x4C4 */ public float HueVariance;
        [NMS(Index = 47)]
        /* 0x4C8 */ public float LightnessVariance;
        [NMS(Index = 62)]
        /* 0x4CC */ public float LimitLifetimeOnMove;
        [NMS(Index = 8)]
        /* 0x4D0 */ public int MaxCount;
        [NMS(Index = 57)]
        /* 0x4D4 */ public float MaxRenderCameraHeight;
        [NMS(Index = 56)]
        /* 0x4D8 */ public float MaxRenderDistance;
        [NMS(Index = 58)]
        /* 0x4DC */ public float MaxSpawnDistance;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        [NMS(Index = 53)]
        /* 0x4E0 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        [NMS(Index = 42)]
        /* 0x4E4 */ public float RotateAroundEmitter;
        [NMS(Index = 46)]
        /* 0x4E8 */ public float SaturationVariance;
        [NMS(Index = 59)]
        /* 0x4EC */ public float SoftFadeStrength;
        // size: 0x6
        public enum SpawnOffsetTypeEnum : uint {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point,
        }
        [NMS(Index = 28)]
        /* 0x4F0 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        [NMS(Index = 27)]
        /* 0x4F4 */ public float StartOffset;
        [NMS(Index = 32)]
        /* 0x4F8 */ public float StartRotationVariation;
        [NMS(Index = 60)]
        /* 0x4FC */ public float SurfaceDistanceFadeStrength;
        [NMS(Index = 41)]
        /* 0x500 */ public float TrackEmitterPosition;
        [NMS(Index = 3)]
        /* 0x504 */ public float TrailRatio;
        [NMS(Index = 38, MxmlName = "U Coordinate")]
        /* 0x508 */ public TkCoordinateOrientation UCoordinate;
        [NMS(Index = 39, MxmlName = "V Coordinate")]
        /* 0x50C */ public TkCoordinateOrientation VCoordinate;
        [NMS(Index = 26)]
        /* 0x510 */ public float Variation;
        [NMS(Index = 40)]
        /* 0x514 */ public float VelocityInheritance;
        [NMS(Index = 16)]
        /* 0x518 */ public TkCurveType EmitterLifeCurve1;
        [NMS(Index = 17)]
        /* 0x519 */ public TkCurveType EmitterLifeCurve2;
        [NMS(Index = 54)]
        /* 0x51A */ public bool FadeRefractionsAtScreenEdge;
        [NMS(Index = 7)]
        /* 0x51B */ public bool Oneshot;
        [NMS(Index = 6)]
        /* 0x51C */ public bool StartEnabled;
        [NMS(Index = 4)]
        /* 0x51D */ public bool TrailIsRibbon;
    }
}
