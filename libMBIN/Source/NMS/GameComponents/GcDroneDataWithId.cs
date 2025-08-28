using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81BD00806BE28233, NameHash = 0xD9A70698)]
    public class GcDroneDataWithId : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcDroneData Data;
        [NMS(Index = 0)]
        /* 0x400 */ public NMSString0x10 Id;
    }
}
