using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcMissionConditionBasePartNear : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public float Distance;
    }
}
