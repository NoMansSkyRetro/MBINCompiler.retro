using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E28F459FC5FD095, NameHash = 0x7322E012)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x39, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}
