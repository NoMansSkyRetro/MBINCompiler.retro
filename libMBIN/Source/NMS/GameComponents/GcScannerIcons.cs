using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6323E6522323CA74, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 37, Size = 0x48, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 59, Size = 0x4)]
        /* 0x0480 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 38)]
        /* 0x04C0 */ public Colour BuildingColour;
        [NMS(Index = 39)]
        /* 0x04D0 */ public Colour GenericColour;
        [NMS(Index = 40)]
        /* 0x04E0 */ public Colour RelicColour;
        [NMS(Index = 41)]
        /* 0x04F0 */ public Colour SignalColour;
        [NMS(Index = 42)]
        /* 0x0500 */ public Colour UnknownColour;
        [NMS(Index = 35, Size = 0x48, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0510 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 36, Size = 0x48, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x14D0 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 32, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2490 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 33, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2C38 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 34, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x33E0 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 3, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x3B88 */ public GcScannerIcon[] Vehicles;
        [NMS(Index = 31, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x3D10 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 57, Size = 0x4)]
        /* 0x3E60 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 58, Size = 0x4)]
        /* 0x3F40 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 60, Size = 0x4)]
        /* 0x4020 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 69, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x4100 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 30)]
        /* 0x4178 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 29)]
        /* 0x41B0 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 48)]
        /* 0x41E8 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 16)]
        /* 0x4220 */ public GcScannerIcon Battle;
        [NMS(Index = 20)]
        /* 0x4258 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 62)]
        /* 0x4290 */ public GcScannerIcon BlackHole;
        [NMS(Index = 13)]
        /* 0x42C8 */ public GcScannerIcon Bounty1;
        [NMS(Index = 14)]
        /* 0x4300 */ public GcScannerIcon Bounty2;
        [NMS(Index = 15)]
        /* 0x4338 */ public GcScannerIcon Bounty3;
        [NMS(Index = 19)]
        /* 0x4370 */ public GcScannerIcon BountySmall;
        [NMS(Index = 22)]
        /* 0x43A8 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 26)]
        /* 0x43E0 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 64)]
        /* 0x4418 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 63)]
        /* 0x4450 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 66)]
        /* 0x4488 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 43)]
        /* 0x44C0 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 67)]
        /* 0x44F8 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 75)]
        /* 0x4530 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 68)]
        /* 0x4568 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 65)]
        /* 0x45A0 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 44)]
        /* 0x45D8 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 45)]
        /* 0x4610 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 7)]
        /* 0x4648 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 12)]
        /* 0x4680 */ public GcScannerIcon Death;
        [NMS(Index = 18)]
        /* 0x46B8 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 28)]
        /* 0x46F0 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 11)]
        /* 0x4728 */ public GcScannerIcon EditingBase;
        [NMS(Index = 9)]
        /* 0x4760 */ public GcScannerIcon Expedition;
        [NMS(Index = 4)]
        /* 0x4798 */ public GcScannerIcon Freighter;
        [NMS(Index = 5)]
        /* 0x47D0 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 82)]
        /* 0x4808 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 23)]
        /* 0x4840 */ public GcScannerIcon Garage;
        [NMS(Index = 27)]
        /* 0x4878 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 46)]
        /* 0x48B0 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 47)]
        /* 0x48E8 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 74)]
        /* 0x4920 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 71)]
        /* 0x4958 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 73)]
        /* 0x4990 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 70)]
        /* 0x49C8 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 72)]
        /* 0x4A00 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 53)]
        /* 0x4A38 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 54)]
        /* 0x4A70 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 55)]
        /* 0x4AA8 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 56)]
        /* 0x4AE0 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 24)]
        /* 0x4B18 */ public GcScannerIcon NPC;
        [NMS(Index = 81)]
        /* 0x4B50 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 77)]
        /* 0x4B88 */ public GcScannerIcon Pet;
        [NMS(Index = 79)]
        /* 0x4BC0 */ public GcScannerIcon PetActivity;
        [NMS(Index = 76)]
        /* 0x4BF8 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 78)]
        /* 0x4C30 */ public GcScannerIcon PetSad;
        [NMS(Index = 83)]
        /* 0x4C68 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 51)]
        /* 0x4CA0 */ public GcScannerIcon PlanetPoleEast;
        [NMS(Index = 49)]
        /* 0x4CD8 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 50)]
        /* 0x4D10 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 52)]
        /* 0x4D48 */ public GcScannerIcon PlanetPoleWest;
        [NMS(Index = 10)]
        /* 0x4D80 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 6)]
        /* 0x4DB8 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 80)]
        /* 0x4DF0 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 61)]
        /* 0x4E28 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 8)]
        /* 0x4E60 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 25)]
        /* 0x4E98 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 1)]
        /* 0x4ED0 */ public GcScannerIcon Ship;
        [NMS(Index = 17)]
        /* 0x4F08 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x4F40 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 21)]
        /* 0x4F78 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 2)]
        /* 0x4FB0 */ public GcScannerIcon VehicleGeneric;
    }
}
