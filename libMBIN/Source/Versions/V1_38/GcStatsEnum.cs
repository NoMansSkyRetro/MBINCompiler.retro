namespace libMBIN.V1_38.Structs
{
    public class GcStatsEnum : NMSTemplate     // size: 0x4
    {
        public int Stat;
        public string[] StatValues()
        {
            return new[]
            {
                "None", "INACTIVE", "BINOC_INTERACTABLE", "PLANTS_PLANTED", "SALVAGE_LOOTED"        // pretty sure this is totally wrong...
            };
        }
    }
}
