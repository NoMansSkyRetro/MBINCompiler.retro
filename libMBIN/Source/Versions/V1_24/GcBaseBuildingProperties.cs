using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcBaseBuildingProperties : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string DefaultInBaseObject;
        [NMS(Size = 0x10)]
        public string DefaultOnTerrainObject;
        [NMS(Size = 0x10)]
        public string DefaultInFreighterObject;
    }
}
