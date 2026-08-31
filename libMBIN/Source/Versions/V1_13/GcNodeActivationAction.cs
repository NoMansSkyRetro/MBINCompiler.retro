using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNodeActivationAction : NMSTemplate   // size: 0x88 
    {
        public int NodeActiveState;
        /*0x00 */ public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle" };
        }

        [NMS(Size = 0x80)]
        /* 0x04 */ public string Name;
        /* 0x84 */ public bool IncludePhysics;
        /* 0x85 */ public bool UseMasterModel;
        [NMS(Size = 2, Ignore = true)]
        /* 0x86 */ public byte[] Padding86;
    }
}
