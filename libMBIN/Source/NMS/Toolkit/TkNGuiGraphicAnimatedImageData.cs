namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD4FAAD41A2019C42, NameHash = 0x3198A29C)]
    public class TkNGuiGraphicAnimatedImageData : NMSTemplate
    {
        [NMS(Index = 2, MxmlName = "Frames Per Second")]
        /* 0x0 */ public float FramesPerSecond;
        [NMS(Index = 7, MxmlName = "Scroll Speed")]
        /* 0x4 */ public float ScrollSpeed;
        [NMS(Index = 6, MxmlName = "Scroll Angle")]
        /* 0x8 */ public short ScrollAngle;
        [NMS(Index = 1, MxmlName = "Blend Frames")]
        /* 0xA */ public bool BlendFrames;
        [NMS(Index = 4, MxmlName = "Frames Horizontal")]
        /* 0xB */ public byte FramesHorizontal;
        [NMS(Index = 5, MxmlName = "Frames Vertical")]
        /* 0xC */ public byte FramesVertical;
        // size: 0x3
        public enum NGuiImageAnimTypeEnum : byte {
            None,
            Animated,
            Scrolling,
        }
        [NMS(Index = 0)]
        /* 0xD */ public NGuiImageAnimTypeEnum NGuiImageAnimType;
        [NMS(Index = 3, MxmlName = "Total Frames")]
        /* 0xE */ public byte TotalFrames;
    }
}
