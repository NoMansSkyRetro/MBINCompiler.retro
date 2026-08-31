using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcBaseBuildingGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Name;
    }
}
