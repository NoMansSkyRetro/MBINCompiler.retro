using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        public GcSeed Seed;
        public int TerrainSettingIndex;
        public GcGalaxyStarTypes GalaxyStarType;
        public GcPlanetClass PlanetClass;
        public GcPlanetSize PlanetSize;
        public GcCreatureRoleDataTable CreatureRoleData;
        public GcTerrainControls Terrain;

        public NMSString0x80 TerrainFile;
        public NMSString0x80 CreatureLandFile;
        public NMSString0x80 CreatureCaveFile;
        public NMSString0x80 CreatureWaterFile;
        public NMSString0x80 CreatureAirFile;
        public List<GcExternalObjectListOptions> ExternalObjectLists;
        public List<int> ExternalObjectListIndices;
    }
}
