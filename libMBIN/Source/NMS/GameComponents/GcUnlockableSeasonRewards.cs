using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB91E438694ECDAB7, NameHash = 0xB908D850)]
    public class GcUnlockableSeasonRewards : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcUnlockableSeasonReward> Table;
    }
}
