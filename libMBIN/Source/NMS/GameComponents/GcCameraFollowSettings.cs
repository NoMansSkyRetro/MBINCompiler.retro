namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F38D2B19F9266B8, NameHash = 0x932D2ED5)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 59)]
        /* 0x10 */ public float AvoidCollisionLRSpeed;
        [NMS(Index = 61)]
        /* 0x14 */ public float AvoidCollisionPushSpeed;
        [NMS(Index = 60)]
        /* 0x18 */ public float AvoidCollisionUDSpeed;
        [NMS(Index = 11)]
        /* 0x1C */ public float BackMaxDistance;
        [NMS(Index = 10)]
        /* 0x20 */ public float BackMinDistance;
        [NMS(Index = 12)]
        /* 0x24 */ public float BackSlopeAdjust;
        [NMS(Index = 13)]
        /* 0x28 */ public float BackSlopeRotationAdjust;
        [NMS(Index = 39)]
        /* 0x2C */ public float CenterBlendTime;
        [NMS(Index = 41)]
        /* 0x30 */ public float CenterMaxSpeed;
        [NMS(Index = 40)]
        /* 0x34 */ public float CenterMaxSpring;
        [NMS(Index = 45)]
        /* 0x38 */ public float CenterStartSpeed;
        [NMS(Index = 38)]
        /* 0x3C */ public float CenterStartTime;
        [NMS(Index = 66)]
        /* 0x40 */ public float CustomBlendTime;
        [NMS(Index = 33)]
        /* 0x44 */ public float DistSpeed;
        [NMS(Index = 34)]
        /* 0x48 */ public float DistSpeedOutsideMainRange;
        [NMS(Index = 35)]
        /* 0x4C */ public float DistStiffness;
        [NMS(Index = 25)]
        /* 0x50 */ public float HorizRotationAngleMaxPerFrame;
        [NMS(Index = 20)]
        /* 0x54 */ public float LeftMaxDistance;
        [NMS(Index = 19)]
        /* 0x58 */ public float LeftMinDistance;
        [NMS(Index = 47)]
        /* 0x5C */ public float LookStickLimitAngle;
        [NMS(Index = 48)]
        /* 0x60 */ public float LookStickOffset;
        [NMS(Index = 52)]
        /* 0x64 */ public float LRProbesRadius;
        [NMS(Index = 51)]
        /* 0x68 */ public float LRProbesRange;
        [NMS(Index = 46)]
        /* 0x6C */ public float MinMoveVelToTriggerSpring;
        [NMS(Index = 1)]
        /* 0x70 */ public float MinSpeed;
        [NMS(Index = 50)]
        /* 0x74 */ public int NumLRProbes;
        [NMS(Index = 53)]
        /* 0x78 */ public int NumUDProbes;
        [NMS(Index = 3)]
        /* 0x7C */ public float OffsetX;
        [NMS(Index = 4)]
        /* 0x80 */ public float OffsetY;
        [NMS(Index = 6)]
        /* 0x84 */ public float OffsetYAlt;
        [NMS(Index = 21)]
        /* 0x88 */ public float OffsetYExtraMaxDistance;
        [NMS(Index = 5)]
        /* 0x8C */ public float OffsetYMinSpeed;
        [NMS(Index = 7)]
        /* 0x90 */ public float OffsetYSlopeExtra;
        [NMS(Index = 8)]
        /* 0x94 */ public float OffsetZFlat;
        [NMS(Index = 23)]
        /* 0x98 */ public float PanFar;
        [NMS(Index = 22)]
        /* 0x9C */ public float PanNear;
        [NMS(Index = 55)]
        /* 0xA0 */ public float ProbeCenterX;
        [NMS(Index = 56)]
        /* 0xA4 */ public float ProbeCenterY;
        [NMS(Index = 57)]
        /* 0xA8 */ public float PushForwardDropoffLR;
        [NMS(Index = 58)]
        /* 0xAC */ public float PushForwardDropoffUD;
        [NMS(Index = 2)]
        /* 0xB0 */ public float SpeedRange;
        [NMS(Index = 36)]
        /* 0xB4 */ public float SpringSpeed;
        [NMS(Index = 54)]
        /* 0xB8 */ public float UDProbesRange;
        [NMS(Index = 24)]
        /* 0xBC */ public float UpGamma;
        [NMS(Index = 15)]
        /* 0xC0 */ public float UpMaxDistance;
        [NMS(Index = 14)]
        /* 0xC4 */ public float UpMinDistance;
        [NMS(Index = 16)]
        /* 0xC8 */ public float UpSlopeAdjust;
        [NMS(Index = 17)]
        /* 0xCC */ public float UpWaveAdjust;
        [NMS(Index = 18)]
        /* 0xD0 */ public float UpWaveAdjustMaxHeight;
        [NMS(Index = 42)]
        /* 0xD4 */ public float VelocityAnticipate;
        [NMS(Index = 43)]
        /* 0xD8 */ public float VelocityAnticipateSpringSpeed;
        [NMS(Index = 44)]
        /* 0xDC */ public float VertMaxSpring;
        [NMS(Index = 28)]
        /* 0xE0 */ public float VertRotationMax;
        [NMS(Index = 27)]
        /* 0xE4 */ public float VertRotationMin;
        [NMS(Index = 29)]
        /* 0xE8 */ public float VertRotationOffset;
        [NMS(Index = 31)]
        /* 0xEC */ public float VertRotationOffsetMaxAngle;
        [NMS(Index = 30)]
        /* 0xF0 */ public float VertRotationOffsetMinAngle;
        [NMS(Index = 26)]
        /* 0xF4 */ public float VertRotationSpeed;
        [NMS(Index = 63)]
        /* 0xF8 */ public bool AvoidCollisionLRUseStickDelay;
        [NMS(Index = 62)]
        /* 0xF9 */ public bool AvoidCollisionUDUseStickDelay;
        [NMS(Index = 49)]
        /* 0xFA */ public bool EnableCollisionDetection;
        [NMS(Index = 37)]
        /* 0xFB */ public bool LockToObjectOnIdle;
        [NMS(Index = 65)]
        /* 0xFC */ public bool UseCustomBlendTime;
        [NMS(Index = 9)]
        /* 0xFD */ public bool UseMinSpeedYOffset;
        [NMS(Index = 64)]
        /* 0xFE */ public bool UseSpeedBasedSpring;
        [NMS(Index = 32)]
        /* 0xFF */ public bool VertStartLookingDown;
    }
}
