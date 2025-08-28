namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB882BBF96EE890AB, NameHash = 0x3CABC6EE)]
    public class TkNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float AgentHeight;
        [NMS(Index = 5)]
        /* 0x04 */ public float AgentMaxSlopeDegrees;
        [NMS(Index = 6)]
        /* 0x08 */ public float AgentMaxStepHeight;
        [NMS(Index = 3)]
        /* 0x0C */ public float AgentRadius;
        [NMS(Index = 4)]
        /* 0x10 */ public float AgentSteepSlopeDegrees;
        [NMS(Index = 14)]
        /* 0x14 */ public float ContourMaxError;
        [NMS(Index = 13)]
        /* 0x18 */ public float ContourMaxLength;
        [NMS(Index = 17)]
        /* 0x1C */ public float DetailMeshMaxError;
        [NMS(Index = 16)]
        /* 0x20 */ public float DetailMeshSampleDistance;
        [NMS(Index = 12)]
        /* 0x24 */ public int RegionMinCellCount;
        [NMS(Index = 0)]
        /* 0x28 */ public bool BuildAsync;
        [NMS(Index = 15)]
        /* 0x29 */ public bool BuildDetailMesh;
        [NMS(Index = 18)]
        /* 0x2A */ public bool BuildPolyBVH;
        [NMS(Index = 10)]
        /* 0x2B */ public bool ErodeWalkableAreas;
        [NMS(Index = 8)]
        /* 0x2C */ public bool FilterLedgeSpans;
        [NMS(Index = 7)]
        /* 0x2D */ public bool FilterLowHangingObstacles;
        [NMS(Index = 9)]
        /* 0x2E */ public bool FilterWalkableLowHeightSpans;
        [NMS(Index = 1)]
        /* 0x2F */ public bool KeepIntermediateRecastData;
        [NMS(Index = 11)]
        /* 0x30 */ public bool MedianFilterWalkableAreas;
    }
}
