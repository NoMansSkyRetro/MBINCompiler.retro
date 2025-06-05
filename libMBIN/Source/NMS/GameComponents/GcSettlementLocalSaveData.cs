using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC6A416F030BCF33, NameHash = 0x94C95B89)]
    public class GcSettlementLocalSaveData : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x30)]
        /* 0x000 */ public ulong[] BuildingSeeds;
        [NMS(Index = 3)]
        /* 0x180 */ public GcByteBeatJukeboxData ByteBeatJukebox;
        [NMS(Index = 4, Size = 0x3)]
        /* 0x288 */ public ulong[] TowerLastUsedTimeStamps;
        [NMS(Index = 0)]
        /* 0x2A0 */ public ulong Seed;
        [NMS(Index = 1, Size = 0x30)]
        /* 0x2A8 */ public int[] Buildings;
        [NMS(Index = 5)]
        /* 0x368 */ public bool RequiresStatConversion;
    }
}
