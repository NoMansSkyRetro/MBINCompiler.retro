using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A91CF92A8D2027E, NameHash = 0x7249CADC)]
    public class GcJourney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyCategory> Categories;
    }
}
