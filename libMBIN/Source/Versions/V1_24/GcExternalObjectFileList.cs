using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public bool OnlyOnExtremeWeather;
        public bool OnlyOnExtremeSentinels;
        public bool OnlyOnDeepWater;
        public bool NotOnExtremePlanets;
        public bool NotOnStartPlanets;

        public GcBiomeType Biome;

        public float ProbabilityOfBeingActive;
        public int MinFilesToChoose;
        public int MaxFilesToChoose;

        public List<GcExternalObjectListOptions> ExternalObjectFiles;

    }
}
