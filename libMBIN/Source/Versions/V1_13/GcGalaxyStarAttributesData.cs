using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcGalaxyStarAttributesData : NMSTemplate // size = 0x58
    {
        public GcGalaxyStarTypes Type;
        public GcGalaxyStarAnomaly Anomaly;
        public int NumberOfPlanets;
        [NMS(Size = 0x10)]
        public GcPlanetSize[] PlanetSizes;
        [NMS(Size = 0x10)]
        public int[] PlanetParentIndices;
        [NMS(Size = 0x10)]
        public GcSeed[] PlanetSeeds;
    }
}
