using FacebookAppUI.DesignPatterns.Visitor.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookAppUI.DesignPatterns.Visitor.Implementors
{
    public class FramerWithOutlineWinForms
    {
        private readonly IFrameableWithOutline r_ObjectToFrame;

        public FramerWithOutlineWinForms(IFrameableWithOutline i_ObjectToFrame)
        {
            r_ObjectToFrame = i_ObjectToFrame;
        }

        public void FrameWithOutline(PaintEventArgs i_PaintEventArgs, Color i_OutlineColor)
        {
            ControlPaint.DrawBorder(i_PaintEventArgs.Graphics, r_ObjectToFrame.ObjectBorder, i_OutlineColor, ButtonBorderStyle.Outset);
        }
    }
}
