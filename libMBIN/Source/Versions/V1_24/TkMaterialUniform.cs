using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class TkMaterialUniform : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }
}
