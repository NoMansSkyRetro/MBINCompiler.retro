using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace libMBIN.V1_00.Structs
{
    // disc layout: 88 textures then 17 RGBA colours (0x2E70)
    public class GcScannerIcons : NMSTemplate
    {
        /* 0x0000 */ public TkTextureResource TaggedBuilding;
        /* 0x0084 */ public TkTextureResource Ship;
        /* 0x0108 */ public TkTextureResource Death;
        /* 0x018C */ public TkTextureResource ShipSmall;
        /* 0x0210 */ public TkTextureResource DeathSmall;
        /* 0x0294 */ public TkTextureResource CircleAnimation;
        /* 0x0318 */ public TkTextureResource HexAnimation;
        /* 0x039C */ public TkTextureResource ArrowSmall;
        /* 0x0420 */ public TkTextureResource ArrowLarge;
        /* 0x04A4 */ public TkTextureResource CompassOutline;
        /* 0x0528 */ public TkTextureResource PickupCrate;
        /* 0x05AC */ public TkTextureResource SpaceStationLarge;

        [NMS(Size = 0xD)]
        /* 0x0630 */ public TkTextureResource[] BuildingIcons;
        [NMS(Size = 0xD)]
        /* 0x0CE4 */ public TkTextureResource[] BuildingIconsLarge;
        [NMS(Size = 0xD)]
        /* 0x1398 */ public TkTextureResource[] BuildingIconsInactive;
        [NMS(Size = 0xD)]
        /* 0x1A4C */ public TkTextureResource[] BuildingIconsInactiveLarge;
        [NMS(Size = 0xD)]
        /* 0x2100 */ public TkTextureResource[] BuildingIconsHuge;

        [NMS(Size = 0xB)]
        /* 0x27B4 */ public TkTextureResource[] ScannableIcons;

        [NMS(Size = 0x11)]
        /* 0x2D60 */ public Colour[] ScannableColours;
    }
}
