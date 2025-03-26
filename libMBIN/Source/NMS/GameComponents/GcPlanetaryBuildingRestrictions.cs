namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAAEB155A8FB7724, NameHash = 0x2179CD2A)]
    public class GcPlanetaryBuildingRestrictions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool RequiresCorruptSentinels;
        [NMS(Index = 2)]
        /* 0x1 */ public bool RequiresRelicWorld;
        [NMS(Index = 1)]
        /* 0x2 */ public bool RequiresWater;
    }
}
