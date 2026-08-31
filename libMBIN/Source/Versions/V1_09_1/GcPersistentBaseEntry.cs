using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_09_1.Structs
{
    public class GcPersistentBaseEntry : NMSTemplate
    {
        /* 0x00 */ public ulong Timestamp;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string ObjectId;
        /* 0x18 */ public ulong UserData;
        /* 0x20 */ public Vector4f Position;
        /* 0x30 */ public Vector4f Up;
        /* 0x40 */ public Vector4f At;
    }
}
