using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcGameMode : NMSTemplate
    {
        public int PresetGameMode;
        public string[] PresetGameModeValues()
        {
            return new[] { "Unspecified", "Normal", "Creative", "Survival" };
        }
    }
}
