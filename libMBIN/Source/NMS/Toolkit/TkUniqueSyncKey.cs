using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9CC2BB5A233E7DE6, NameHash = 0xD7A68810)]
    public class TkUniqueSyncKey : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public ulong Index;
        [NMS(Index = 0)]
        /* 0x8 */ public TkSaveID OwnerID;
    }
}
