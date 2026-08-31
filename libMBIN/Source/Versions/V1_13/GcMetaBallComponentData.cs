using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcMetaBallComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string File;
        [NMS(Size = 0x20)]
        /* 0x080 */ public string Root;
        /* 0x0A0 */ public float Radius;
        /* 0x0B0 */ public Vector4f MinSize;
        /* 0x0C0 */ public Vector4f MaxSize;
    }
}
