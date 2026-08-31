using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcNPCPlacementComponentData : NMSTemplate // 0x20 bytes
    {
        public bool SearchPlacementFromMaster;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding0x1;
        public List<NMSString0x10> PlacementInfosToApply;
    }
}
