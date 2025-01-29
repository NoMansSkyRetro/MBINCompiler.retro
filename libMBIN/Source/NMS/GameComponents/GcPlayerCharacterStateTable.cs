using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9640C565D875653, NameHash = 0x4F0D63A1)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x13, EnumType = typeof(GcPlayerCharacterStateType.CharacterStateEnum))]
        /* 0x0 */ public GcPlayerCharacterStateData[] CharacterStates;
    }
}
