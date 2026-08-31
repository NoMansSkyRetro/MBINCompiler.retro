namespace libMBIN.V1_38.Structs
{
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
        public int AtlasPathProgressType;
        public string[] AtlasPathProgressTypeValues()
        {
            return new[] { "IncrementPathProgress", "FinalStoryAtlas" };
        }
    }
}
