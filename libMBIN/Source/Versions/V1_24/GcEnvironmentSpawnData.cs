using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcEnvironmentSpawnData : NMSTemplate
    {
        public List<GcCreatureSpawnData> Creatures;
        public List<GcObjectSpawnData> Landmarks;
        public List<GcObjectSpawnData> Objects;
        public List<GcObjectSpawnData> DetailObjects;
        public List<GcSelectableObjectSpawnList> SelectableObjects;
    }
}
