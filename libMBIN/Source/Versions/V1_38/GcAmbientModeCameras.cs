using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcAmbientModeCameras : NMSTemplate      // size: 0x30
    {
        public List<GcCameraAmbientBuildingData> BuildingCameraAnimations;
        public List<GcCameraAmbientSpaceData> SpaceCameraAnimations;
        public List<GcCameraAmbientSpecialData> SpecialCameraAnimations;
    }
}
