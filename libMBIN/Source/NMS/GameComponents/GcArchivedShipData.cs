using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCAFC663DD4353544, NameHash = 0xF25F122A)]
    public class GcArchivedShipData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcPlayerOwnershipData Ownership;
        [NMS(Index = 1)]
        /* 0x4B0 */ public GcCharacterCustomisationSaveData Customisation;
        [NMS(Index = 4)]
        /* 0x518 */ public GcSpaceshipClasses ArchivedClass;
        [NMS(Index = 5)]
        /* 0x51C */ public GcInventoryClass ArchivedInventoryClass;
        [NMS(Index = 3)]
        /* 0x520 */ public NMSString0x80 ArchivedName;
        [NMS(Index = 2)]
        /* 0x5A0 */ public bool UsesLegacyColours;
    }
}
