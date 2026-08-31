using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Size=7,Ignore =false)]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS(Size = 7, Ignore = false)]
        /* 0x380 */ public float[] NPCRaceScale;

        public List<GcUniqueNPCSpawnData> UniqueNPCs;
        public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
