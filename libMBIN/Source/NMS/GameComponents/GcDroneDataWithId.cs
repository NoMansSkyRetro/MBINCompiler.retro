using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF76D76CAAECB1252, NameHash = 0xD9A70698)]
    public class GcDroneDataWithId : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcDroneData Data;
        [NMS(Index = 0)]
        /* 0x400 */ public NMSString0x10 Id;
    }
}
