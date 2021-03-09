using FacebookAppUI.DesignPatterns.Visitor.Interfaces;
using System.Windows.Forms;

namespace FacebookAppUI.DesignPatterns.Visitor.Implementors
{
    public class EnlargerOnClick
    {
        private readonly IEnlrageableOnClick r_ObjectToEnlarge;
        
        public EnlargerOnClick(IEnlrageableOnClick i_ObjectToEnlarge)
        {
            r_ObjectToEnlarge = i_ObjectToEnlarge;
        }

        public void EnlargeOnClick()
        {
            Form popupForm = new Form();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = r_ObjectToEnlarge.Image;
            pictureBox.Size = popupForm.Size = r_ObjectToEnlarge.Image.Size;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            popupForm.Controls.Add(pictureBox);

            popupForm.ShowDialog();
        }
    }
}
