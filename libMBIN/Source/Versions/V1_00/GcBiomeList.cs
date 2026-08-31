namespace libMBIN.V1_00.Structs
{
    public class GcBiomeList : NMSTemplate // disc: 8 biome slots (release added a 9th)
    {
        [NMS(Size = 8)]
        public float[] BiomeProbability;
    }
}
