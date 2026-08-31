using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        /* 0x00 */ public float Time;
        [NMS(Size = 0x20)]
        /* 0x04 */ public  string SquadName;
        /* 0x24 */ public Vector2f WarpIntervalRange;
    }
}
