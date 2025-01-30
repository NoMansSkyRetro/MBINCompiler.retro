namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB1BA376067A82FC3, NameHash = 0x3CABC6EE)]
    public class TkNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float AgentHeight;
        [NMS(Index = 4)]
        /* 0x04 */ public float AgentMaxSlopeDegrees;
        [NMS(Index = 5)]
        /* 0x08 */ public float AgentMaxStepHeight;
        [NMS(Index = 3)]
        /* 0x0C */ public float AgentRadius;
        [NMS(Index = 13)]
        /* 0x10 */ public float ContourMaxError;
        [NMS(Index = 12)]
        /* 0x14 */ public float ContourMaxLength;
        [NMS(Index = 16)]
        /* 0x18 */ public float DetailMeshMaxError;
        [NMS(Index = 15)]
        /* 0x1C */ public float DetailMeshSampleDistance;
        [NMS(Index = 11)]
        /* 0x20 */ public int RegionMinCellCount;
        [NMS(Index = 0)]
        /* 0x24 */ public bool BuildAsync;
        [NMS(Index = 14)]
        /* 0x25 */ public bool BuildDetailMesh;
        [NMS(Index = 17)]
        /* 0x26 */ public bool BuildPolyBVH;
        [NMS(Index = 9)]
        /* 0x27 */ public bool ErodeWalkableAreas;
        [NMS(Index = 7)]
        /* 0x28 */ public bool FilterLedgeSpans;
        [NMS(Index = 6)]
        /* 0x29 */ public bool FilterLowHangingObstacles;
        [NMS(Index = 8)]
        /* 0x2A */ public bool FilterWalkableLowHeightSpans;
        [NMS(Index = 1)]
        /* 0x2B */ public bool KeepIntermediateRecastData;
        [NMS(Index = 10)]
        /* 0x2C */ public bool MedianFilterWalkableAreas;
    }
}
