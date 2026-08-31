using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class TkAnimNodeFrameData : NMSTemplate      // size: 0x30
    {
        public List<Vector4f> Rotations;
        public List<Vector4f> Translations;
        public List<Vector4f> Scales;
    }

}
