namespace libMBIN.V1_38.Structs
{
    public class TkProbability : NMSTemplate
    {
        public int Probability;
        public string[] ProbabilityValues()
        {
            return new[] { "Common", "Uncommon", "Rare", "Extraordinary" };
        }
    }
}
