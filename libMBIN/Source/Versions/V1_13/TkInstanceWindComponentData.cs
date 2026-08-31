using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class TkInstanceWindComponentData : NMSTemplate
    {
        /* 0x00 */ public bool EnableLdsWind;
        /* 0x04 */ public float BaseMass;
        /* 0x08 */ public float MassReduction;
        /* 0x0C */ public float BaseSpring;
        /* 0x10 */ public float SpringReduction;
        /* 0x14 */ public float LinearDamping;
        /* 0x18 */ public float SpringNonDirFactor;
        /* 0x1C */ public float SpringLengthFactor;
    }
}
