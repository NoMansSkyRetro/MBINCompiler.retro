namespace libMBIN.V1_38.Structs
{
    public class GcPlanetLife : NMSTemplate
    {
        public int LifeSetting;
        public string[] LifeSettingValues()
        {
            return new[] { "Dead", "Low", "Mid", "Full" };
        }
    }
}
