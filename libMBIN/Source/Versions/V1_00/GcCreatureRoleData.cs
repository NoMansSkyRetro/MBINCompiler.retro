using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcCreatureRoleData : NMSTemplate // disc 0x378
    {
        public GcSeed Seed;
        public GcCreatureTypes CreatureType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
        public NMSString0x10 CreatureId;
        public GcCreatureRoleDescription Description;
        public GcCreatureInfo Info;
        public GcTerrainTileType TileType;
        public int Diet;
        public float BaseScale;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding48C;
    }
}
