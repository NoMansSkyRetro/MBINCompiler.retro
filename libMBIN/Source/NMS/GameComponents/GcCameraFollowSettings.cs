namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC75CC88ABAB0A7E, NameHash = 0x932D2ED5)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 55)]
        /* 0x10 */ public float AvoidCollisionLRSpeed;
        [NMS(Index = 57)]
        /* 0x14 */ public float AvoidCollisionPushSpeed;
        [NMS(Index = 56)]
        /* 0x18 */ public float AvoidCollisionUDSpeed;
        [NMS(Index = 9)]
        /* 0x1C */ public float BackMaxDistance;
        [NMS(Index = 8)]
        /* 0x20 */ public float BackMinDistance;
        [NMS(Index = 10)]
        /* 0x24 */ public float BackSlopeAdjust;
        [NMS(Index = 11)]
        /* 0x28 */ public float BackSlopeRotationAdjust;
        [NMS(Index = 37)]
        /* 0x2C */ public float CenterBlendTime;
        [NMS(Index = 39)]
        /* 0x30 */ public float CenterMaxSpeed;
        [NMS(Index = 38)]
        /* 0x34 */ public float CenterMaxSpring;
        [NMS(Index = 43)]
        /* 0x38 */ public float CenterStartSpeed;
        [NMS(Index = 36)]
        /* 0x3C */ public float CenterStartTime;
        [NMS(Index = 62)]
        /* 0x40 */ public float CustomBlendTime;
        [NMS(Index = 31)]
        /* 0x44 */ public float DistSpeed;
        [NMS(Index = 32)]
        /* 0x48 */ public float DistSpeedOutsideMainRange;
        [NMS(Index = 33)]
        /* 0x4C */ public float DistStiffness;
        [NMS(Index = 23)]
        /* 0x50 */ public float HorizRotationAngleMaxPerFrame;
        [NMS(Index = 18)]
        /* 0x54 */ public float LeftMaxDistance;
        [NMS(Index = 17)]
        /* 0x58 */ public float LeftMinDistance;
        [NMS(Index = 44)]
        /* 0x5C */ public float LookStickLimitAngle;
        [NMS(Index = 48)]
        /* 0x60 */ public float LRProbesRadius;
        [NMS(Index = 47)]
        /* 0x64 */ public float LRProbesRange;
        [NMS(Index = 1)]
        /* 0x68 */ public float MinSpeed;
        [NMS(Index = 46)]
        /* 0x6C */ public int NumLRProbes;
        [NMS(Index = 49)]
        /* 0x70 */ public int NumUDProbes;
        [NMS(Index = 3)]
        /* 0x74 */ public float OffsetX;
        [NMS(Index = 4)]
        /* 0x78 */ public float OffsetY;
        [NMS(Index = 5)]
        /* 0x7C */ public float OffsetYAlt;
        [NMS(Index = 19)]
        /* 0x80 */ public float OffsetYExtraMaxDistance;
        [NMS(Index = 6)]
        /* 0x84 */ public float OffsetYSlopeExtra;
        [NMS(Index = 7)]
        /* 0x88 */ public float OffsetZFlat;
        [NMS(Index = 21)]
        /* 0x8C */ public float PanFar;
        [NMS(Index = 20)]
        /* 0x90 */ public float PanNear;
        [NMS(Index = 51)]
        /* 0x94 */ public float ProbeCenterX;
        [NMS(Index = 52)]
        /* 0x98 */ public float ProbeCenterY;
        [NMS(Index = 53)]
        /* 0x9C */ public float PushForwardDropoffLR;
        [NMS(Index = 54)]
        /* 0xA0 */ public float PushForwardDropoffUD;
        [NMS(Index = 2)]
        /* 0xA4 */ public float SpeedRange;
        [NMS(Index = 34)]
        /* 0xA8 */ public float SpringSpeed;
        [NMS(Index = 50)]
        /* 0xAC */ public float UDProbesRange;
        [NMS(Index = 22)]
        /* 0xB0 */ public float UpGamma;
        [NMS(Index = 13)]
        /* 0xB4 */ public float UpMaxDistance;
        [NMS(Index = 12)]
        /* 0xB8 */ public float UpMinDistance;
        [NMS(Index = 14)]
        /* 0xBC */ public float UpSlopeAdjust;
        [NMS(Index = 15)]
        /* 0xC0 */ public float UpWaveAdjust;
        [NMS(Index = 16)]
        /* 0xC4 */ public float UpWaveAdjustMaxHeight;
        [NMS(Index = 40)]
        /* 0xC8 */ public float VelocityAnticipate;
        [NMS(Index = 41)]
        /* 0xCC */ public float VelocityAnticipateSpringSpeed;
        [NMS(Index = 42)]
        /* 0xD0 */ public float VertMaxSpring;
        [NMS(Index = 26)]
        /* 0xD4 */ public float VertRotationMax;
        [NMS(Index = 25)]
        /* 0xD8 */ public float VertRotationMin;
        [NMS(Index = 27)]
        /* 0xDC */ public float VertRotationOffset;
        [NMS(Index = 29)]
        /* 0xE0 */ public float VertRotationOffsetMaxAngle;
        [NMS(Index = 28)]
        /* 0xE4 */ public float VertRotationOffsetMinAngle;
        [NMS(Index = 24)]
        /* 0xE8 */ public float VertRotationSpeed;
        [NMS(Index = 59)]
        /* 0xEC */ public bool AvoidCollisionLRUseStickDelay;
        [NMS(Index = 58)]
        /* 0xED */ public bool AvoidCollisionUDUseStickDelay;
        [NMS(Index = 45)]
        /* 0xEE */ public bool EnableCollisionDetection;
        [NMS(Index = 35)]
        /* 0xEF */ public bool LockToObjectOnIdle;
        [NMS(Index = 61)]
        /* 0xF0 */ public bool UseCustomBlendTime;
        [NMS(Index = 60)]
        /* 0xF1 */ public bool UseSpeedBasedSpring;
        [NMS(Index = 30)]
        /* 0xF2 */ public bool VertStartLookingDown;
    }
}
