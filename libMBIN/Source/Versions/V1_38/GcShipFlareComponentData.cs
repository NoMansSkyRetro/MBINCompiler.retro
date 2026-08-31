namespace libMBIN.V1_38.Structs
{
    public class GcShipFlareComponentData : NMSTemplate
    {
        public int FlareType;
        public string[] FlareTypeValues()
        {
            return new[] { "Default"};
        }
    }
}
