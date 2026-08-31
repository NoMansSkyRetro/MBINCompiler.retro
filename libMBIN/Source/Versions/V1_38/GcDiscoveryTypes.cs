namespace libMBIN.V1_38.Structs
{
    public class GcDiscoveryTypes : NMSTemplate
    {
        public int DiscoveryType;
        public string[] DiscoveryTypeValues()
        {
            return new[] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector", "Building", "Interactable", "Sentinel" };
        }
    }
}
