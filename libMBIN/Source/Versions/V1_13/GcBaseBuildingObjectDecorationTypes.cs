using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
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
