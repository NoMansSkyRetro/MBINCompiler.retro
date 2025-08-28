namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EED5A450512E5CC, NameHash = 0xB4F01F64)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        // size: 0x14
        public enum CharacterStateEnum : uint {
            Idle,
            Jog,
            JogUphill,
            JogDownhill,
            SteepSlope,
            Sliding,
            Run,
            Airborne,
            JetpackBoost,
            RocketBoots,
            Riding,
            Swimming,
            SwimmingJetpack,
            Death,
            FullBodyOverride,
            Spacewalk,
            SpacewalkAtmosphere,
            LowGWalk,
            LowGRun,
            Fishing,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CharacterStateEnum CharacterState;
    }
}
