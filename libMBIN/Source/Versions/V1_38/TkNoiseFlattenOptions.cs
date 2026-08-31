namespace libMBIN.V1_38.Structs
{
    public class TkNoiseFlattenOptions : NMSTemplate
    {
        public int Flattening;
        public string[] FlatteningValues()
        {
            return new[] { "None", "Natural", "Artificial", "AddResource" };
        }

        public int WaterPlacement;
        public string[] WaterPlacementValues()
        {
            return new[] { "None", "Underwater" };
        }
    }
}
