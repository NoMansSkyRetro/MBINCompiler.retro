using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    public class GcBuildingFilenameList : NMSTemplate // 0x1600
    {
        [NMS(Size = 0x16)]
        public GcBuildingFilename[] BuildingFiles;
    }
}
