using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17DB5B87DF806280, NameHash = 0x7322E012)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}
