using libMBIN.NMS; using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
namespace libMBIN.V1_09_1.Structs
{
    // 1.09.1 layout (0x38 per element, from BIOMEFILENAMES.MBIN): a Name and three extra
    // dwords that the rc1-era def (0x20) does not carry.
    public class GcExternalObjectFileList : NMSTemplate
    {
        public NMSString0x10 Name;
        public int Unknown10;
        public int MinFilesToChoose;
        public int MaxFilesToChoose;
        public float ProbabilityOfBeingActive;
        public int Unknown20;
        public int Unknown24;
        public List<GcExternalObjectListOptions> ExternalObjectFiles;
    }
}
