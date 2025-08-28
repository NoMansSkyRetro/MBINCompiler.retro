namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1C5A7EAA075F31E8, NameHash = 0x4BCE318F)]
    public class TkNavMeshMovementDebugVisOptions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float VelocityArrowLookAheadTime;
        // size: 0xD
        public enum NavMeshMovementDebugVisFlagsEnum : ushort {
            None = 0x0,
            Corridor = 0x1,
            PointPath = 0x2,
            LocalBoundary = 0x4,
            CurrentPos = 0x8,
            Target = 0x10,
            CurrentVel = 0x20,
            DesiredVelNoRepel = 0x40,
            DesiredVel = 0x80,
            ResultVel = 0x100,
            Flocking = 0x200,
            VelocitySampling = 0x400,
            ObstacleAvoidance = 0x800,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public NavMeshMovementDebugVisFlagsEnum NavMeshMovementDebugVisFlags;
    }
}
