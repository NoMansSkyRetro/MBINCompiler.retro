namespace libMBIN.V1_24.Structs
{
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
		public float HardModeMultiplier;
        public bool DisableMultiplier;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
