using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    [NMS(Alignment = 0x4)]
    public class GcMissionFaction : NMSTemplate
    {
        public int MissionFaction;
        public string[] MissionFactionValues()
        {
            return new[] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" };
        }
    }
}
