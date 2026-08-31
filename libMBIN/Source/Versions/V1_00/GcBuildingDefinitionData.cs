using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcBuildingDefinitionData : NMSTemplate // 0x48 bytes
    {
        public TkNoiseFlattenOptions FlattenType;
        public GcBuildingClusterPlacement BuildingClusterPlacement;
        public bool AddWaypoint;
        public bool AddShelter;
        public bool AddLandingPad;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full"})]
        public float[] Density;

        public int NumModelsToGenerate;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding2C;

        public NMSString0x10 TextureNameHint;
        public float OverrideRadius;
        public bool GivesShelter;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding45;
    }
}
