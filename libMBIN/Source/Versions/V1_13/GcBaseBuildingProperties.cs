using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
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
