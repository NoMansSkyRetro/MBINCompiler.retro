namespace libMBIN.V1_38.Structs
{
    public class GcResourceOrigin : NMSTemplate
    {
        public int ResourceOrigin;
        public string[] ResourceOriginValues()
        {
            return new[] { "Terrain", "Crystal", "Asteroid", "Robot", "Depot" };
        }
    }
}
