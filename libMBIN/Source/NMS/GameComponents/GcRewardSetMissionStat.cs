namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48EDCCD8801CDB82, NameHash = 0x2CEF47EC)]
    public class GcRewardSetMissionStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int ValueToAdd;
        [NMS(Index = 0)]
        /* 0x4 */ public int ValueToSet;
    }
}
