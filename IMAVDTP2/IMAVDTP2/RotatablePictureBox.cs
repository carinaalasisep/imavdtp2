using System.Drawing;
using System.Windows.Forms;

namespace IMAVDTP2
{
    public class RotatablePictureBox : PictureBox
    {
        private float rotationAngle;

        public float RotationAngle
        {
            get { return rotationAngle; }
            set
            {
                rotationAngle = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            if (Image != null)
            {
                e.Graphics.TranslateTransform(Width / 2, Height / 2);
                e.Graphics.RotateTransform(rotationAngle);
                e.Graphics.TranslateTransform(-Width / 2, -Height / 2);

                e.Graphics.DrawImage(Image, ClientRectangle);
            }
        }
    }

}
