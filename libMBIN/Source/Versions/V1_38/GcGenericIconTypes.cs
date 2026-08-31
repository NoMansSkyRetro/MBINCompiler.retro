namespace libMBIN.V1_38.Structs
{
    public class GcGenericIconTypes : NMSTemplate
    {
        public int GenericIconType;
        public string[] GenericIconTypeValues()
        {
            return new[] { "None", "Interaction", "SpaceStation", "SpaceAnomaly", "SpaceAtlas" };
        }
    }
}
