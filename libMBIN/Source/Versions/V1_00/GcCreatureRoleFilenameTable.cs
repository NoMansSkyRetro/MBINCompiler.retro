using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcCreatureRoleFilenameTable : NMSTemplate // disc: 7 biomes, no LifeChance
    {
        [NMS(Size = 7, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead" })]
        public GcCreatureRoleFilenameList[] BiomeFiles;

        public GcCreatureRoleFilenameList UnderwaterBiomeFiles;
        public GcCreatureRoleFilenameList CaveBiomeFiles;
        public GcCreatureRoleFilenameList AirBiomeFiles;
        public GcCreatureRoleFilenameList GroundBiomeFiles;
    }
}
