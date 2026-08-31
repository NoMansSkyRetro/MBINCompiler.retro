namespace libMBIN.V1_24.Structs
{
    public class GcRarity : NMSTemplate
    {
        public int Rarity;

        public string[] RarityValues()
        {
            return new[] { "Common", "Uncommon", "Rare", "Extraordinary", "None" };
        }
    }
}
