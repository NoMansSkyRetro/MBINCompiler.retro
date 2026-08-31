using libMBIN.NMS;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_13.Structs
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
