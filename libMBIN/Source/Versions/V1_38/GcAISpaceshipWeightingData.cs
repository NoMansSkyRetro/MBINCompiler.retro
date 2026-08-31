namespace libMBIN.V1_38.Structs
{
    [NMS(Size = 0x1C)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter", "Royal" })]
        public float[] CivilianClassWeightings;
    }
}
