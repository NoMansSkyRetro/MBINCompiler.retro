using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    [NMS(Size = 0x20)]
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }
}
