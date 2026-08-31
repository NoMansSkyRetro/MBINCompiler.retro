using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Ambient;

        public int MaxDistance;

        public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
