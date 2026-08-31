using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcMissionPageHint : NMSTemplate
    {
        public int MissionPageHint;
        public string[] MissionPageHintValues()
        {
            return new[] { "None", "Suit", "Ship", "Vehicle", "Freighter", "Wiki", "MissionLog", "Discovery", "Journey" };
        }
    }
}
