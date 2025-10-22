namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3AA532B20C668FE9, NameHash = 0xB29233BB)]
    public class GcStatsEnum : NMSTemplate
    {
        // size: 0x1B
        public enum StatEnumEnum : uint {
            None,
            DEPOTS_BROKEN,
            FPODS_BROKEN,
            PLANTS_PLANTED,
            SALVAGE_LOOTED,
            TREASURE_FOUND,
            QUADS_KILLED,
            WALKERS_KILLED,
            FLORA_KILLED,
            PLANTS_GATHERED,
            BONES_FOUND,
            C_SENT_KILLS,
            STORM_CRYSTALS,
            BURIED_PROPS,
            MINIWORM_KILL,
            POOP_COLLECTED,
            GRAVBALLS,
            EGG_PODS,
            CORRUPT_PILLAR,
            DRONE_SHARDS,
            MECHS_KILLED,
            SPIDERS_KILLED,
            SM_SPIDER_KILLS,
            SEAGLASS,
            RUINS_LOOTED,
            STONE_KILLS,
            BIGGSDEBRIS_POI,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatEnumEnum StatEnum;
    }
}
