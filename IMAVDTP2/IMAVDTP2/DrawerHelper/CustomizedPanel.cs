using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.MediaFoundation.OPM;
using VisioForge.Libs.NAudio.Utils;

namespace IMAVDTP2.DrawerHelper
{
    public class CustomizedPanel : Panel
    {
        public string shape { get; set; }
        public Color color { get; set; }
        public float angle { get; set; }

        public CustomizedPanel(string shape,Color color,float angle)
        {
            this.shape = shape;
            this.color = color;
            this.angle = angle;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (shape == "circle")
            {
                drawCircle(e);
            }
            if(shape == "triangle")
            {
                drawTriangle(e);
            }
            if(shape == "star")
            {
                drawStar(e);
            }
            if (shape == "square")
            {
                drawSquare(e);
            }
        }

        private void drawSquare(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //rotation
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2); 
            e.Graphics.RotateTransform(angle); 
            e.Graphics.TranslateTransform(-this.Width / 2, -this.Height / 2);
            //---//

            int sideSize = Math.Min(this.Width, this.Height);
            //lower value to assure a square
            int x = (this.Width - sideSize) / 2;
            int y = (this.Height - sideSize) / 2;

            // draw using the color
            using (Brush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, x, y, sideSize, sideSize);
            }
        }

        private void drawStar(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //rotation
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.TranslateTransform(-this.Width / 2, -this.Height / 2);
            //---//

            int sideSize = Math.Min(this.Width, this.Height);

            // points para desenhar a estrela
            PointF[] points = new PointF[10];
            float externalRay = sideSize / 2f;
            float internalRay = externalRay * 0.4f;

            for (int i = 0; i < 10; i++)
            {
                float angle = (float)(i * 36 * Math.PI / 180);
                float x1 = externalRay * (float)Math.Sin(angle);
                float y1 = externalRay * (float)Math.Cos(angle);
                points[i] = new PointF(x1 + externalRay, y1 + externalRay);

                i++;
                angle = (float)(i * 36 * Math.PI / 180);
                float x2 = internalRay * (float)Math.Sin(angle);
                float y2 = internalRay * (float)Math.Cos(angle);
                points[i] = new PointF(x2 + externalRay, y2 + externalRay);
            }

            // Draw the star
            using (Brush brush = new SolidBrush(color))
            {
                g.FillPolygon(brush, points);
            }
        }

        private void drawTriangle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //rotation
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.TranslateTransform(-this.Width / 2, -this.Height / 2);
            //---//

            //secure value for an equilateral triangle
            int sideSize = Math.Min(this.Width, this.Height);
            int x = (this.Width - sideSize) / 2;
            int y = (this.Height - sideSize) / 2;

            Point[] points = new Point[3];
            // Low Left Corner
            points[0] = new Point(x, y + sideSize);
            // Low Right Corner
            points[1] = new Point(x + sideSize, y + sideSize);
            // Top
            points[2] = new Point(x + sideSize / 2, y);

            using (Brush brush = new SolidBrush(color))
            {
                // Draw Triangle
                g.FillPolygon(brush, points);
            }
        }

        private void drawCircle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //rotation
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.TranslateTransform(-this.Width / 2, -this.Height / 2);
            //---//

            int diameter = Math.Min(this.Width, this.Height);

            //secure value for a circle 
            int x = (this.Width - diameter) / 2;
            int y = (this.Height - diameter) / 2;

            using (Brush brush = new SolidBrush(color))
            {
                // Draw circle
                g.FillEllipse(brush, x, y, diameter, diameter);
            }
        }
    }
}
