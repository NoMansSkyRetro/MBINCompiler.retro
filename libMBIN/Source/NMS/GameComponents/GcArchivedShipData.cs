using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B0B87CEAA5CF25F, NameHash = 0xF25F122A)]
    public class GcArchivedShipData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcPlayerOwnershipData Ownership;
        [NMS(Index = 1)]
        /* 0x4D0 */ public GcCharacterCustomisationSaveData Customisation;
        [NMS(Index = 4)]
        /* 0x538 */ public GcSpaceshipClasses ArchivedClass;
        [NMS(Index = 5)]
        /* 0x53C */ public GcInventoryClass ArchivedInventoryClass;
        [NMS(Index = 3)]
        /* 0x540 */ public NMSString0x80 ArchivedName;
        [NMS(Index = 2)]
        /* 0x5C0 */ public bool UsesLegacyColours;
    }
}
