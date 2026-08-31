using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcSavedInteractionRaceData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 7)]
        public int[] SavedRaceIndicies; // unsure if this is float[] or not, code for this template is very strange
    }
}
