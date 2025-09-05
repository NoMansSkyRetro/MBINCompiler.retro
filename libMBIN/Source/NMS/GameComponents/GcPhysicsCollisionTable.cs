using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83B91D17C7AFA27E, NameHash = 0xF5EE5140)]
    public class GcPhysicsCollisionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPhysicsCollisionGroupCollidesWith> CollisionTable;
    }
}
