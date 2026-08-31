using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class TkVolumeTriggerType : NMSTemplate
    {
        public int VolumeTriggerType;
        public string[] VolumeTriggerTypeValues()
        {
            return new[] { "Open", "GenericInterior", "Corridor", "SmallRoom", "LargeRoom", "OpenCovered" };
        }
    }
}
