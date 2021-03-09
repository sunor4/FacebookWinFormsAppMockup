using FacebookAppUI.DesignPatterns.Visitor.Implementors;
using FacebookAppUI.DesignPatterns.Visitor.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookAppUI.Controls
{
    public partial class LivelyPictureBox : PictureBox, IEnlrageableOnClick, ISizeChangeableOnHover, IFrameableWithOutline
    {
        private const float k_SizeEnlargeMultiplier = 1.2f;
        private readonly EnlargerOnClick r_Enlarger;
        private readonly SizeChangerOnHover r_SizeChanger;
        private readonly FramerWithOutlineWinForms r_Framer;
        public Color OutlineColor { get; set; }
        public Rectangle ObjectBorder
        {
            get { return ClientRectangle; }
        }

        public LivelyPictureBox()
        {
            InitializeComponent();
            this.Tag = OutlineColor;
            r_Enlarger = new EnlargerOnClick(this);
            r_SizeChanger = new SizeChangerOnHover(this);
            r_Framer = new FramerWithOutlineWinForms(this);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (this.Visible && this.Tag != null)
            {
                r_Framer.FrameWithOutline(pe, OutlineColor);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            showOutline();
            r_SizeChanger.ChangeSize(k_SizeEnlargeMultiplier);
            this.Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hideOutline();
            r_SizeChanger.RevertToOriginal();
            this.Refresh();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            r_Enlarger.EnlargeOnClick();
        }

        private void showOutline()
        {
            this.Tag = OutlineColor;
            this.Refresh();
        }

        private void hideOutline()
        {
            this.Tag = null;
            this.Refresh();
        }
    }
}
