using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcMissileComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
		/* 0x010 */ public float NoTargetLife;
        [NMS(Size = 0x10)]
		/* 0x018 */ public string Trail;
	}
}