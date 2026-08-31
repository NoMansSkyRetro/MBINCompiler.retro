namespace libMBIN.V1_38.Structs
{
    public class GcStatType : NMSTemplate // not the same as GcStatsTypes
    {
        public int StatType;
        public string[] StatTypeValues()
        {
            return new[] { "Int", "Float", "AvgRate" };
        }
    }
}
