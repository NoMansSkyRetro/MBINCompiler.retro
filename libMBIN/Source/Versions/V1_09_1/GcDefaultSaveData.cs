using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_09_1.Structs
{
    public class GcDefaultSaveData : NMSTemplate
    {
        // 1.13: Spawn follows State directly (the era def's 8-byte pad plus the align
        // gap displaced Spawn by 16 and duplicated the first dynamic entry)
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x3B1D0 */ public GcPlayerSpawnStateData Spawn;
    }
}
