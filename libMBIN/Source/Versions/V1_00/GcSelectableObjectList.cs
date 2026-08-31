using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcSelectableObjectList : NMSTemplate // disc: 0x20, no Race
    {
        public NMSString0x10 Name;
        public List<GcSelectableObjectData> Options;
    }
}
