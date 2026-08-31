namespace libMBIN.V1_24.Structs
{
    public class GcAISpaceshipTypes : NMSTemplate
    {
        public int ShipType;
        public string[] ShipTypeValues()
        {
            return new[] { "None", "Pirate", "Police", "Trader", "Freighter" };
        }
    }
}
