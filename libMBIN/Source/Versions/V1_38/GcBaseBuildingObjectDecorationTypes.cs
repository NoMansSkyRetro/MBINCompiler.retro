using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        public int BaseBuildingDecorationType;
        public string[] BaseBuildingDecorationTypeValues()
        {
            return new[] { "Normal", "SurfaceNormal", "Ceiling", "Terrain", "Substance", "Interior", "Exterior", "Plant"};
        }
    }
}
