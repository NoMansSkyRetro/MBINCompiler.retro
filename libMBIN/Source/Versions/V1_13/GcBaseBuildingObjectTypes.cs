using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcBaseBuildingObjectTypes : NMSTemplate
    {
        public int BaseBuildingObjectType;
        public string[] BaseBuildingObjectTypeValues()
        {
            return new[] { "Building", "BuildingFoundation", "BuildingDecoration", "Decoration", "Foundation" };
        }
    }
}
