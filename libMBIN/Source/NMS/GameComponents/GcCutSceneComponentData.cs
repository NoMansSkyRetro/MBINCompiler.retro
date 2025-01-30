using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9675A37EE0B0EE8, NameHash = 0x7F665957)]
    public class GcCutSceneComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCutSceneData CutSceneData;
    }
}
