namespace libMBIN.V1_00.Structs
{
    public class GcBiomeListPerStarType : NMSTemplate // 0x90
    {
        [NMS(Size = 4)]
        public GcBiomeList[] StarType;

        [NMS(Size = 4)]
        public float[] LifeChance;
    }
}
