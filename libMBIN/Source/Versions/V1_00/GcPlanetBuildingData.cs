using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_00.Structs
{
    public class GcPlanetBuildingData : NMSTemplate
    {
        public List<GcBuildingSpawnData> Buildings;
        public float Spacing;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
