using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7154CB12A35E2AB7, NameHash = 0xBBFF31AB)]
    public class GcMultitoolPoolData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString File;
        [NMS(Index = 2)]
        /* 0x10 */ public int MaxDraw;
        [NMS(Index = 1)]
        /* 0x14 */ public int MinDraw;
        [NMS(Index = 3)]
        /* 0x18 */ public float PoolProbability;
        [NMS(Index = 4)]
        /* 0x1C */ public GcMultitoolPoolType PoolType;
    }
}
