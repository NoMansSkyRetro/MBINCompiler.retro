namespace libMBIN.V1_24.Structs
{
    public class GcTechnologyRarity : NMSTemplate
    {
        public int TechnologyRarity;

        public string[] TechnologyRarityValues()
        {
            return new[] { "Normal", "VeryCommon", "Common", "Rare", "VeryRare", "Impossible", "Always" };
        }
    }
}
