namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8E4E82C912744E7, NameHash = 0xCE31A5B9)]
    public class GcBaseBuildingCameraMode : NMSTemplate
    {
        // size: 0x3
        public enum BaseBuildingCameraModeEnum : uint {
            Inactive,
            FreeCam,
            FocusCam,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingCameraModeEnum BaseBuildingCameraMode;
    }
}
