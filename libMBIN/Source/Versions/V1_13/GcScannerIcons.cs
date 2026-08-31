using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace libMBIN.V1_13.Structs
{
    public class GcScannerIcons : NMSTemplate // 0x43E0
    {
        /* 0x0000 */ public TkTextureResource TaggedBuilding;
        /* 0x0084 */ public TkTextureResource Ship;
        /* 0x0108 */ public TkTextureResource Freighter;
        /* 0x018C */ public TkTextureResource FreighterBase;
        /* 0x0210 */ public TkTextureResource PlayerFreighter;
        /* 0x0294 */ public TkTextureResource PlayerBase;
        /* 0x0318 */ public TkTextureResource Death;
        /* 0x039C */ public TkTextureResource Bounty1;
        /* 0x0420 */ public TkTextureResource Bounty2;
        /* 0x04A4 */ public TkTextureResource Bounty3;
        /* 0x0528 */ public TkTextureResource Battle;
        /* 0x05AC */ public TkTextureResource ShipSmall;
        /* 0x0630 */ public TkTextureResource DeathSmall;
        /* 0x06B4 */ public TkTextureResource BountySmall;
        /* 0x0738 */ public TkTextureResource BattleSmall;
        /* 0x07BC */ public TkTextureResource HexAnimation;
        /* 0x0840 */ public TkTextureResource ArrowSmall;
        /* 0x08C4 */ public TkTextureResource ArrowLarge;

        [NMS(Size = 5)]
        /* 0x0948 */ public TkTextureResource[] GenericIcons;

        [NMS(Size = 0xF)]
        /* 0x0BDC */ public TkTextureResource[] BuildingIcons;

        [NMS(Size = 0xF)]
        /* 0x1398 */ public TkTextureResource[] BuildingIconsLarge;

        [NMS(Size = 0xF)]
        /* 0x1B54 */ public TkTextureResource[] BuildingIconsInactive;

        [NMS(Size = 0xF)]
        /* 0x2310 */ public TkTextureResource[] BuildingIconsInactiveLarge;

        [NMS(Size = 0xF)]
        /* 0x2ACC */ public TkTextureResource[] BuildingIconsHuge;

        [NMS(Size = 0x18)]
        /* 0x3288 */ public TkTextureResource[] ScannableIcons;

        // Colour's 0x10 alignment absorbs the 8 zero bytes after the icon block
        [NMS(Size = 0x17)]
        /* 0x3EF0 */ public Colour[] ScannableColours;

        /* 0x4060 */ public Colour BuildingColour;
        /* 0x4070 */ public Colour GenericColour;
        /* 0x4080 */ public Colour InactiveColour;
        /* 0x4090 */ public Colour RelicColour;
        /* 0x40A0 */ public Colour SignalColour;
        /* 0x40B0 */ public Colour UnknownColour;

        /* 0x40C0 */ public TkTextureResource CreatureDiscovered;
        /* 0x4144 */ public TkTextureResource CreatureUndiscovered;
        /* 0x41C8 */ public TkTextureResource CreatureUnknown;
        /* 0x424C */ public TkTextureResource MessageBeacon;
        /* 0x42D0 */ public TkTextureResource MessageBeaconSmall;
        /* 0x4354 */ public TkTextureResource BaseBuildingMarker;

        [NMS(Size = 8, Ignore = true)]
        /* 0x43D8 */ public byte[] EndPadding;
    }
}
