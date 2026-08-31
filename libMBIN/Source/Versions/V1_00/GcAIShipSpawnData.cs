using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcAIShipSpawnData : NMSTemplate
    {
        public NMSString0x20 Message;

        public TkInputEnum InputEnum;
        public bool WarpIn;
        public GcAISpaceshipRoles ShipRole;
        public float MinRange;
        public float Scale;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding34;
        public NMSString0x10 Reward;
        public NMSString0x20 RewardMessage;
        public float Unknown68;
        public Vector2f Spread;
        public Vector2f Count;
        public Vector2f StartTime;
        public int SpawnShape;
        public string[] SpawnShapeValues()
        {
            return new[] { "Sphere", "Cone" };
        }

        public GcShipAIPerformanceArray AIPerformanceArray;

        public List<GcAIShipSpawnData> ChildSpawns;
    }
}
