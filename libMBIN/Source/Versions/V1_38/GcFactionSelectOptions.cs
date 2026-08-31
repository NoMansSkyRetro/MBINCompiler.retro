namespace libMBIN.V1_38.Structs
{
    public class GcFactionSelectOptions : NMSTemplate
    {
        public int FactionOption;
        public string[] FactionOptionValues()
        {
            return new[] { "DataDefined", "CurrentMission", "CurrentSystem" };
        }
        public GcMissionFaction Faction;
    }
}
