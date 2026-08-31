using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcCreatureMovementData : NMSTemplate
    {
        public List<GcCreatureMoveAnimData> Anims;

        public float MoveRange;
        public float MoveSpeedScale;
        public float HeightMin;
        public float HeightMax;
        public float HeightTime;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
    }
}
