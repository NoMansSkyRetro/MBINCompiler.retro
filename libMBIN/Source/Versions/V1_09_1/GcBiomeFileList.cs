using libMBIN.NMS;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_09_1.Structs
{
    public class GcBiomeFileList : NMSTemplate
    {
        // 9 biome slots in 1.09.1 (the disc build has 8)
        [NMS(Size = 9)]
        public NMSString0x80[] BiomeFiles;

        public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
