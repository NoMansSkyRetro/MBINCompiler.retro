using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcRewardSubstance : NMSTemplate
    {
        public GcRealitySubstanceCategory ItemCategory;
        public GcRarity ItemRarity;
        public int ItemLevel;
        public int AmountMin;
        public int AmountMax;
        public float HardModeMultiplier;
    }
}
