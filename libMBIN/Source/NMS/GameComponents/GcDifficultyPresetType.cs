namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC443F99B2C030440, NameHash = 0xB8B0A2CB)]
    public class GcDifficultyPresetType : NMSTemplate
    {
        // size: 0x7
        public enum DifficultyPresetTypeEnum : uint {
            Invalid,
            Custom,
            Normal,
            Creative,
            Relaxed,
            Survival,
            Permadeath,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DifficultyPresetTypeEnum DifficultyPresetType;
    }
}
