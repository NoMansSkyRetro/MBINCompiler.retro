using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
		public float HardModeMultiplier;
    }
}
