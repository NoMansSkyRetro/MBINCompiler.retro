namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D03FF5D22FE8495, NameHash = 0x297A9843)]
    public class AxisSpecification : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f CustomAxis;
        // size: 0x7
        public enum AxisEnum : uint {
            X,
            Y,
            Z,
            NegativeX,
            NegativeY,
            NegativeZ,
            CustomAxis,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public AxisEnum Axis;
    }
}
