using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x70F4615EAEE73B48, NameHash = 0x20FD4240)]
    public class TkRigidBodyComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSTemplate Properties;
        // size: 0x3
        public enum TargetNodeEnum : uint {
            Model,
            MasterModel,
            Attachment,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public TargetNodeEnum TargetNode;
        [NMS(Index = 5)]
        /* 0x14 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 2)]
        /* 0x18 */ public bool AddToWorldImmediately;
        [NMS(Index = 1)]
        /* 0x19 */ public bool AddToWorldOnPrepare;
        [NMS(Index = 4)]
        /* 0x1A */ public bool TriggerVolume;
    }
}
