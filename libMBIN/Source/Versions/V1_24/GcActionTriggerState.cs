using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }
}
