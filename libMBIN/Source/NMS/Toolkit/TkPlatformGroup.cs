using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5252A58737FCD05, NameHash = 0xB83DD00)]
    public class TkPlatformGroup : NMSTemplate
    {
        // size: 0x6
        [Flags]
        public enum PlatformMaskEnum : uint {
            None = 0x0,
            Playfab = 0x1,
            Steam = 0x2,
            Playstation = 0x4,
            XBox = 0x8,
            Nintendo = 0x10,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PlatformMaskEnum PlatformMask;
    }
}
