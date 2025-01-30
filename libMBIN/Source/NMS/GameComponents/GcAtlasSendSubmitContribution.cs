namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0CE99133E84CF8E, NameHash = 0x8011D801)]
    public class GcAtlasSendSubmitContribution : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Contribution;
        [NMS(Index = 0)]
        /* 0x4 */ public int MissionIndex;
    }
}
