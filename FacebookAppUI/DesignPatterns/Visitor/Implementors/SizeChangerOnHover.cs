using FacebookAppUI.DesignPatterns.Visitor.Interfaces;
using System.Drawing;

namespace FacebookAppUI.DesignPatterns.Visitor.Implementors
{
    public class SizeChangerOnHover
    {
        private readonly ISizeChangeableOnHover r_ObjectToSizeChange;
        private readonly Size r_OriginalSize;

        public SizeChangerOnHover(ISizeChangeableOnHover i_ObjectToSizeChange)
        {
            r_ObjectToSizeChange = i_ObjectToSizeChange;
            r_OriginalSize = i_ObjectToSizeChange.Size;
        }

        public void ChangeSize(float i_SizeMultiplier)
        {
            r_ObjectToSizeChange.Size = new Size((int)(r_OriginalSize.Width * i_SizeMultiplier), (int)(r_OriginalSize.Height * i_SizeMultiplier));
        }

        public void RevertToOriginal()
        {
            r_ObjectToSizeChange.Size = r_OriginalSize;
        }
    }
}
