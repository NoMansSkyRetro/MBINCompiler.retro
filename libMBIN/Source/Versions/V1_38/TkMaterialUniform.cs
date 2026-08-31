using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    [NMS(Alignment = 0x10)]
    public class TkMaterialUniform : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }
}
