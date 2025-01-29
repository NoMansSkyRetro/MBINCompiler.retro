using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB87F941E7DBE5FB6, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 37, Size = 0x47, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 59, Size = 0x4)]
        /* 0x0470 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 38)]
        /* 0x04B0 */ public Colour BuildingColour;
        [NMS(Index = 39)]
        /* 0x04C0 */ public Colour GenericColour;
        [NMS(Index = 40)]
        /* 0x04D0 */ public Colour RelicColour;
        [NMS(Index = 41)]
        /* 0x04E0 */ public Colour SignalColour;
        [NMS(Index = 42)]
        /* 0x04F0 */ public Colour UnknownColour;
        [NMS(Index = 35, Size = 0x47, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0500 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 36, Size = 0x47, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x1488 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 32, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2410 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 33, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2BB8 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 34, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3360 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 3, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x3B08 */ public GcScannerIcon[] Vehicles;
        [NMS(Index = 31, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x3C90 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 57, Size = 0x4)]
        /* 0x3DE0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 58, Size = 0x4)]
        /* 0x3EC0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 60, Size = 0x4)]
        /* 0x3FA0 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 69, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x4080 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 30)]
        /* 0x40F8 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 29)]
        /* 0x4130 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 48)]
        /* 0x4168 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 16)]
        /* 0x41A0 */ public GcScannerIcon Battle;
        [NMS(Index = 20)]
        /* 0x41D8 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 62)]
        /* 0x4210 */ public GcScannerIcon BlackHole;
        [NMS(Index = 13)]
        /* 0x4248 */ public GcScannerIcon Bounty1;
        [NMS(Index = 14)]
        /* 0x4280 */ public GcScannerIcon Bounty2;
        [NMS(Index = 15)]
        /* 0x42B8 */ public GcScannerIcon Bounty3;
        [NMS(Index = 19)]
        /* 0x42F0 */ public GcScannerIcon BountySmall;
        [NMS(Index = 22)]
        /* 0x4328 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 26)]
        /* 0x4360 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 64)]
        /* 0x4398 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 63)]
        /* 0x43D0 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 66)]
        /* 0x4408 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 43)]
        /* 0x4440 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 67)]
        /* 0x4478 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 75)]
        /* 0x44B0 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 68)]
        /* 0x44E8 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 65)]
        /* 0x4520 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 44)]
        /* 0x4558 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 45)]
        /* 0x4590 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 7)]
        /* 0x45C8 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 12)]
        /* 0x4600 */ public GcScannerIcon Death;
        [NMS(Index = 18)]
        /* 0x4638 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 28)]
        /* 0x4670 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 11)]
        /* 0x46A8 */ public GcScannerIcon EditingBase;
        [NMS(Index = 9)]
        /* 0x46E0 */ public GcScannerIcon Expedition;
        [NMS(Index = 4)]
        /* 0x4718 */ public GcScannerIcon Freighter;
        [NMS(Index = 5)]
        /* 0x4750 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 82)]
        /* 0x4788 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 23)]
        /* 0x47C0 */ public GcScannerIcon Garage;
        [NMS(Index = 27)]
        /* 0x47F8 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 46)]
        /* 0x4830 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 47)]
        /* 0x4868 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 74)]
        /* 0x48A0 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 71)]
        /* 0x48D8 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 73)]
        /* 0x4910 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 70)]
        /* 0x4948 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 72)]
        /* 0x4980 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 53)]
        /* 0x49B8 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 54)]
        /* 0x49F0 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 55)]
        /* 0x4A28 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 56)]
        /* 0x4A60 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 24)]
        /* 0x4A98 */ public GcScannerIcon NPC;
        [NMS(Index = 81)]
        /* 0x4AD0 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 77)]
        /* 0x4B08 */ public GcScannerIcon Pet;
        [NMS(Index = 79)]
        /* 0x4B40 */ public GcScannerIcon PetActivity;
        [NMS(Index = 76)]
        /* 0x4B78 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 78)]
        /* 0x4BB0 */ public GcScannerIcon PetSad;
        [NMS(Index = 83)]
        /* 0x4BE8 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 51)]
        /* 0x4C20 */ public GcScannerIcon PlanetPoleEast;
        [NMS(Index = 49)]
        /* 0x4C58 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 50)]
        /* 0x4C90 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 52)]
        /* 0x4CC8 */ public GcScannerIcon PlanetPoleWest;
        [NMS(Index = 10)]
        /* 0x4D00 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 6)]
        /* 0x4D38 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 80)]
        /* 0x4D70 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 61)]
        /* 0x4DA8 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 8)]
        /* 0x4DE0 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 25)]
        /* 0x4E18 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 1)]
        /* 0x4E50 */ public GcScannerIcon Ship;
        [NMS(Index = 17)]
        /* 0x4E88 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x4EC0 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 21)]
        /* 0x4EF8 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 2)]
        /* 0x4F30 */ public GcScannerIcon VehicleGeneric;
    }
}
