using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_09_1.Structs
{
    public class TkVoxelGeneratorData : NMSTemplate
    {
        public GcSeed BaseSeed;
        public float SeaRatio;
        public float NoSeaBaseLevel;
        public TkNoiseVoxelTypeEnum NoiseVoxelType1;
        public TkNoiseVoxelTypeEnum NoiseVoxelType2;

        [NMS(Size = 7)]
        public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 9)]
        public TkNoiseGridData[] GridLayers;
        [NMS(Size = 7)]
        public TkNoiseFeatureData[] Features;

        public float Unknown125C; // 1.09.1: extra dword before the cave block
        public TkNoiseCaveData CavesUnderground;
        public float MinimumCaveDepth;
        public float CaveRoofSmoothingDist;
        public float MaximumSeaLevelCaveDepth;
        public float BuildingTextureRadius;
        public float BuildingSmoothingRadius;
        public float BuildingSmoothingHeight;
        public float WaterFadeInDistance;
        public float Unknown12FC;
        
        public TkVoxelGeneratorRegionData Regions;
    }
}
