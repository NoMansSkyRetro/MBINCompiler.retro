using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BABB0299EC3BB5B, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 38, Size = 0x4B, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 60, Size = 0x4)]
        /* 0x04B0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 39)]
        /* 0x04F0 */ public Colour BuildingColour;
        [NMS(Index = 40)]
        /* 0x0500 */ public Colour GenericColour;
        [NMS(Index = 41)]
        /* 0x0510 */ public Colour RelicColour;
        [NMS(Index = 42)]
        /* 0x0520 */ public Colour SignalColour;
        [NMS(Index = 43)]
        /* 0x0530 */ public Colour UnknownColour;
        [NMS(Index = 36, Size = 0x4B, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0540 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 37, Size = 0x4B, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x15A8 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 33, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2610 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 34, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2DB8 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 35, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3560 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 4, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x3D08 */ public GcScannerIcon[] Vehicles;
        [NMS(Index = 32, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x3E90 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 58, Size = 0x4)]
        /* 0x3FE0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 59, Size = 0x4)]
        /* 0x40C0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 61, Size = 0x4)]
        /* 0x41A0 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 70, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x4280 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 31)]
        /* 0x42F8 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 30)]
        /* 0x4330 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 49)]
        /* 0x4368 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 17)]
        /* 0x43A0 */ public GcScannerIcon Battle;
        [NMS(Index = 21)]
        /* 0x43D8 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 63)]
        /* 0x4410 */ public GcScannerIcon BlackHole;
        [NMS(Index = 14)]
        /* 0x4448 */ public GcScannerIcon Bounty1;
        [NMS(Index = 15)]
        /* 0x4480 */ public GcScannerIcon Bounty2;
        [NMS(Index = 16)]
        /* 0x44B8 */ public GcScannerIcon Bounty3;
        [NMS(Index = 20)]
        /* 0x44F0 */ public GcScannerIcon BountySmall;
        [NMS(Index = 23)]
        /* 0x4528 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 27)]
        /* 0x4560 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 65)]
        /* 0x4598 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 64)]
        /* 0x45D0 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 67)]
        /* 0x4608 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 44)]
        /* 0x4640 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 68)]
        /* 0x4678 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 76)]
        /* 0x46B0 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 69)]
        /* 0x46E8 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 66)]
        /* 0x4720 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 45)]
        /* 0x4758 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 46)]
        /* 0x4790 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 8)]
        /* 0x47C8 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 13)]
        /* 0x4800 */ public GcScannerIcon Death;
        [NMS(Index = 19)]
        /* 0x4838 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 29)]
        /* 0x4870 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 12)]
        /* 0x48A8 */ public GcScannerIcon EditingBase;
        [NMS(Index = 10)]
        /* 0x48E0 */ public GcScannerIcon Expedition;
        [NMS(Index = 5)]
        /* 0x4918 */ public GcScannerIcon Freighter;
        [NMS(Index = 6)]
        /* 0x4950 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 83)]
        /* 0x4988 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 24)]
        /* 0x49C0 */ public GcScannerIcon Garage;
        [NMS(Index = 28)]
        /* 0x49F8 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 47)]
        /* 0x4A30 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 48)]
        /* 0x4A68 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 75)]
        /* 0x4AA0 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 72)]
        /* 0x4AD8 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 74)]
        /* 0x4B10 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 71)]
        /* 0x4B48 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 73)]
        /* 0x4B80 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 54)]
        /* 0x4BB8 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 55)]
        /* 0x4BF0 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 56)]
        /* 0x4C28 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 57)]
        /* 0x4C60 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 25)]
        /* 0x4C98 */ public GcScannerIcon NPC;
        [NMS(Index = 82)]
        /* 0x4CD0 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 78)]
        /* 0x4D08 */ public GcScannerIcon Pet;
        [NMS(Index = 80)]
        /* 0x4D40 */ public GcScannerIcon PetActivity;
        [NMS(Index = 77)]
        /* 0x4D78 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 79)]
        /* 0x4DB0 */ public GcScannerIcon PetSad;
        [NMS(Index = 84)]
        /* 0x4DE8 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 52)]
        /* 0x4E20 */ public GcScannerIcon PlanetPoleEast;
        [NMS(Index = 50)]
        /* 0x4E58 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 51)]
        /* 0x4E90 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 53)]
        /* 0x4EC8 */ public GcScannerIcon PlanetPoleWest;
        [NMS(Index = 11)]
        /* 0x4F00 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 7)]
        /* 0x4F38 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 81)]
        /* 0x4F70 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 62)]
        /* 0x4FA8 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 9)]
        /* 0x4FE0 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 26)]
        /* 0x5018 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 2)]
        /* 0x5050 */ public GcScannerIcon Ship;
        [NMS(Index = 18)]
        /* 0x5088 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x50C0 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 1)]
        /* 0x50F8 */ public GcScannerIcon TaggedPlanet;
        [NMS(Index = 22)]
        /* 0x5130 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 3)]
        /* 0x5168 */ public GcScannerIcon VehicleGeneric;
    }
}
