using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x27193EB29F88AC25, NameHash = 0xEDB31590)]
    public class TkProceduralTextureChosenOptionSampler : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkProceduralTextureChosenOption> Options;
    }
}
