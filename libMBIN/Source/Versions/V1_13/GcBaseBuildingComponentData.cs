using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcBaseBuildingComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string RegisterID;
        /* 0x010 */ public GcPersistentBaseTypes Type;
    }
}