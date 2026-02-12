namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8FEAA076E89B8DE, NameHash = 0x94497FE7)]
    public class GcNetworkOwnershipPriority : NMSTemplate
    {
        // size: 0x5
        public enum NetworkOwnershipPriorityEnum : byte {
            Lowest,
            CargoOnTruckBed,
            CargoGrabbedByGravLaser,
            CargoInScrapyard,
            Highest,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NetworkOwnershipPriorityEnum NetworkOwnershipPriority;
    }
}
