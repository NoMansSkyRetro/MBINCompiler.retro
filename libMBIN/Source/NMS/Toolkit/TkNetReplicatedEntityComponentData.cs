using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2D19B9401FCC6B9B, NameHash = 0x466B710A)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x80> ReplicaComponentMask;
        // size: 0x9
        public enum ReplicationRangeEnum : uint {
            NotSet,
            System,
            SystemLocal,
            Planet,
            PlanetLocal,
            Space,
            SpaceStation,
            Nexus,
            Ship,
        }
        [NMS(Index = 1)]
        /* 0x10 */ public ReplicationRangeEnum ReplicationRange;
        // size: 0x2
        public enum SpawnTypeEnum : uint {
            Basic,
            Creature,
        }
        [NMS(Index = 2)]
        /* 0x14 */ public SpawnTypeEnum SpawnType;
        [NMS(Index = 3)]
        /* 0x18 */ public bool IgnoreComponents;
        [NMS(Index = 5)]
        /* 0x19 */ public bool MarkModelAsMasterModel;
        [NMS(Index = 4)]
        /* 0x1A */ public bool ReplicateToShipmates;
    }
}
