using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4ED8016C19C4F2EE, NameHash = 0xB6917754)]
    public class TkAnimStateMachineTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkLayeredAnimStateMachineData> Table;
    }
}
