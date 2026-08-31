namespace libMBIN.V1_38.Structs
{
    public class GcMissionCategory : NMSTemplate
    {
        public int MissionCategory;
        public string[] MissionCategoryValues()
        {
            return new[] { "Info", "Mission", "Danger", "Urgent" };
        }
    }
}
