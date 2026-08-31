using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNPCPlacementComponentData : NMSTemplate // 0x20 bytes
    {
        public bool SearchPlacementFromMaster;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding0x1;
        public List<NMSString0x10> PlacementInfosToApply;
    }
}
