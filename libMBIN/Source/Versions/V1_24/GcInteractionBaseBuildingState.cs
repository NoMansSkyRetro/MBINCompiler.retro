using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcInteractionBaseBuildingState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public int Time;
    }
}
