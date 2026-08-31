using System.Collections.Generic;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace libMBIN.V1_13.Structs
{
    public class TkAnimMetadata : NMSTemplate
    {
        public int FrameCount;
        public int NodeCount;

        public List<TkAnimNodeData> NodeData;
        public List<TkAnimNodeFrameData> AnimFrameData;

        public TkAnimNodeFrameData StillFrameData;
    }
}
