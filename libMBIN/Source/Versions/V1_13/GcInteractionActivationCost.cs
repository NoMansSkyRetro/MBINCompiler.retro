using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcInteractionActivationCost : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string SubstanceId;
        /* 0x10 */ public List<NMSString0x10> AltIds;

        /* 0x20 */ public int Cost;
        /* 0x24 */ public bool Repeat;

        [NMS(Size = 3, Ignore = true)]
        /* 0x25 */ public byte[] Padding25;
		
		[NMS(Size = 0x10)]
		/* 0x28 */ public string RequiredTech;
    }
}
