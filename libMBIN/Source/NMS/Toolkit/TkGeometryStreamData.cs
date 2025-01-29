using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x96C44D7A8878AEA5, NameHash = 0x40025754)]
    public class TkGeometryStreamData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkMeshData> StreamDataArray;
    }
}
