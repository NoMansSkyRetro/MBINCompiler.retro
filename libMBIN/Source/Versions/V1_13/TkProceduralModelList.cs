using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class TkProceduralModelList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public List<NMSString0x80> List;
    }
}
