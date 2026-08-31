using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;

        // widened from 8: real floats sit in what was the 16-align gap before Spawn
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x3B1D0 */ public byte[] Padding3B1C8;

        /* 0x3B1E0 */ public GcPlayerSpawnStateData Spawn;
    }
}
