using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 9)]
        public NMSString0x80[] BiomeFiles;

        public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
