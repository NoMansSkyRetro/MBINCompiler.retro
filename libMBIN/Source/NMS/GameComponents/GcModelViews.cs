namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7866A2D38461A24, NameHash = 0x69104096)]
    public class GcModelViews : NMSTemplate
    {
        // size: 0x32
        public enum ModelViewsEnum : uint {
            Suit,
            SplitSuit,
            SuitWithCape,
            Weapon,
            Ship,
            Corvette,
            SpookShip,
            Vehicle,
            DiscoveryMain,
            DiscoveryThumbnail,
            WonderThumbnail,
            WonderThumbnailCreatureSmall,
            WonderThumbnailCreatureMed,
            WonderThumbnailCreatureLarge,
            WonderThumbnailFloraSmall,
            WonderThumbnailFloraLarge,
            WonderThumbnailMineralSmall,
            WonderThumbnailMineralLarge,
            ToolboxMain,
            ToolboxThumbnail,
            TradeSuit,
            TradeShip,
            TradeCompareShips,
            TradeCompareWeapons,
            HUDThumbnail,
            Interaction,
            Freighter,
            TradeFreighter,
            TradeChest,
            TradeCapsule,
            TradeFrigate,
            TerrainBall,
            FreighterChest,
            Submarine,
            TradeCooker,
            SuitRefiner,
            SuitRefinerWithCape,
            FreighterRepair,
            DiscoveryPlanetaryMapping,
            Mech,
            PetThumbnail,
            PetThumbnailUI,
            PetLarge,
            SquadronPilotLarge,
            SquadronPilotThumbnail,
            SquadronSpaceshipThumbnail,
            VehicleRefiner,
            FishingFloat,
            ModelViewer,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModelViewsEnum ModelViews;
    }
}
