using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93E6F51646D90BAF, NameHash = 0xC50F2CF9)]
    public class GcPersistentBaseDifficultyData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcDifficultyPresetType DifficultyPreset;
        // size: 0x1
        [Flags]
        public enum PersistentBaseDifficultyFlagsEnum : uint {
            None,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public PersistentBaseDifficultyFlagsEnum PersistentBaseDifficultyFlags;
    }
}
