using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    [NMS(Size = 0x58)]
    public class GcActionTrigger : NMSTemplate
    {
        public NMSTemplate Trigger;
        public List<NMSTemplate> Action;
    }
}
