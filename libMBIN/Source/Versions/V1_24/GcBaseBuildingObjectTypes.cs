using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
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
