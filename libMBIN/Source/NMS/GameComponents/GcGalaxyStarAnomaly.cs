namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD37E0A97A57C1942, NameHash = 0x1C2295C9)]
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
        // size: 0x5
        public enum GalaxyStarAnomalyEnum : uint {
            None,
            AtlasStation,
            AtlasStationFinal,
            BlackHole,
            MiniStation,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyStarAnomalyEnum GalaxyStarAnomaly;
    }
}
