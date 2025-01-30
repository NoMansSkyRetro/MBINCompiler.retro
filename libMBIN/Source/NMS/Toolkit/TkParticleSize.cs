using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x20CFAAD464AC7EC2, NameHash = 0xC1679FBE)]
    public class TkParticleSize : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public TkEmitterFloatProperty GeneralSize;
        [NMS(Index = 4, Size = 0x10)]
        /* 0x038 */ public float[] PointAmplitudes;
        [NMS(Index = 6, Size = 0x10)]
        /* 0x078 */ public float[] PointRotations;
        [NMS(Index = 5, Size = 0x10)]
        /* 0x0B8 */ public float[] PointTimes;
        [NMS(Index = 8)]
        /* 0x0F8 */ public int CurvePointCount;
        [NMS(Index = 7)]
        /* 0x0FC */ public float CurveStrength;
        [NMS(Index = 3)]
        /* 0x100 */ public float Max;
        [NMS(Index = 2)]
        /* 0x104 */ public float Min;
        [NMS(Index = 1)]
        /* 0x108 */ public bool ManualSketchCurve;
    }
}
