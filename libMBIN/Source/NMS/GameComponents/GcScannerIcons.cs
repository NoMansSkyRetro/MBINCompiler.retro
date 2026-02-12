using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2821A08F8965E70F, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 40, Size = 0x4C, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 62, Size = 0x4)]
        /* 0x04C0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 41)]
        /* 0x0500 */ public Colour BuildingColour;
        [NMS(Index = 42)]
        /* 0x0510 */ public Colour GenericColour;
        [NMS(Index = 43)]
        /* 0x0520 */ public Colour RelicColour;
        [NMS(Index = 44)]
        /* 0x0530 */ public Colour SignalColour;
        [NMS(Index = 45)]
        /* 0x0540 */ public Colour UnknownColour;
        [NMS(Index = 38, Size = 0x4C, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0550 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 39, Size = 0x4C, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x15F0 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 35, Size = 0x25, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2690 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 36, Size = 0x25, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2EA8 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 37, Size = 0x25, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x36C0 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 5, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x3ED8 */ public GcScannerIcon[] Vehicles;
        [NMS(Index = 34, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x4060 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 63, Size = 0x4)]
        /* 0x41B0 */ public GcScannerIcon[] NetworkFSPlayerCorvetteTeleporter;
        [NMS(Index = 60, Size = 0x4)]
        /* 0x4290 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 61, Size = 0x4)]
        /* 0x4370 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 64, Size = 0x4)]
        /* 0x4450 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 73, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x4530 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 33)]
        /* 0x45A8 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 32)]
        /* 0x45E0 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 51)]
        /* 0x4618 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 18)]
        /* 0x4650 */ public GcScannerIcon Battle;
        [NMS(Index = 22)]
        /* 0x4688 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 66)]
        /* 0x46C0 */ public GcScannerIcon BlackHole;
        [NMS(Index = 15)]
        /* 0x46F8 */ public GcScannerIcon Bounty1;
        [NMS(Index = 16)]
        /* 0x4730 */ public GcScannerIcon Bounty2;
        [NMS(Index = 17)]
        /* 0x4768 */ public GcScannerIcon Bounty3;
        [NMS(Index = 21)]
        /* 0x47A0 */ public GcScannerIcon BountySmall;
        [NMS(Index = 24)]
        /* 0x47D8 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 29)]
        /* 0x4810 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 3)]
        /* 0x4848 */ public GcScannerIcon Corvette;
        [NMS(Index = 28)]
        /* 0x4880 */ public GcScannerIcon CorvetteDeployedTeleporter;
        [NMS(Index = 68)]
        /* 0x48B8 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 67)]
        /* 0x48F0 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 70)]
        /* 0x4928 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 46)]
        /* 0x4960 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 71)]
        /* 0x4998 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 79)]
        /* 0x49D0 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 72)]
        /* 0x4A08 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 69)]
        /* 0x4A40 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 47)]
        /* 0x4A78 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 48)]
        /* 0x4AB0 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 9)]
        /* 0x4AE8 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 14)]
        /* 0x4B20 */ public GcScannerIcon Death;
        [NMS(Index = 20)]
        /* 0x4B58 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 31)]
        /* 0x4B90 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 13)]
        /* 0x4BC8 */ public GcScannerIcon EditingBase;
        [NMS(Index = 11)]
        /* 0x4C00 */ public GcScannerIcon Expedition;
        [NMS(Index = 6)]
        /* 0x4C38 */ public GcScannerIcon Freighter;
        [NMS(Index = 7)]
        /* 0x4C70 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 86)]
        /* 0x4CA8 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 25)]
        /* 0x4CE0 */ public GcScannerIcon Garage;
        [NMS(Index = 30)]
        /* 0x4D18 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 49)]
        /* 0x4D50 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 50)]
        /* 0x4D88 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 78)]
        /* 0x4DC0 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 75)]
        /* 0x4DF8 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 77)]
        /* 0x4E30 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 74)]
        /* 0x4E68 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 76)]
        /* 0x4EA0 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 56)]
        /* 0x4ED8 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 57)]
        /* 0x4F10 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 58)]
        /* 0x4F48 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 59)]
        /* 0x4F80 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 26)]
        /* 0x4FB8 */ public GcScannerIcon NPC;
        [NMS(Index = 85)]
        /* 0x4FF0 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 81)]
        /* 0x5028 */ public GcScannerIcon Pet;
        [NMS(Index = 83)]
        /* 0x5060 */ public GcScannerIcon PetActivity;
        [NMS(Index = 80)]
        /* 0x5098 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 82)]
        /* 0x50D0 */ public GcScannerIcon PetSad;
        [NMS(Index = 87)]
        /* 0x5108 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 54)]
        /* 0x5140 */ public GcScannerIcon PlanetPoleEast;
        [NMS(Index = 52)]
        /* 0x5178 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 53)]
        /* 0x51B0 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 55)]
        /* 0x51E8 */ public GcScannerIcon PlanetPoleWest;
        [NMS(Index = 12)]
        /* 0x5220 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 8)]
        /* 0x5258 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 84)]
        /* 0x5290 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 65)]
        /* 0x52C8 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 10)]
        /* 0x5300 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 27)]
        /* 0x5338 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 2)]
        /* 0x5370 */ public GcScannerIcon Ship;
        [NMS(Index = 19)]
        /* 0x53A8 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x53E0 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 1)]
        /* 0x5418 */ public GcScannerIcon TaggedPlanet;
        [NMS(Index = 23)]
        /* 0x5450 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 4)]
        /* 0x5488 */ public GcScannerIcon VehicleGeneric;
    }
}
