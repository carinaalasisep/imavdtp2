using Color = System.Drawing.Color;

namespace IMAVDTP2.DrawerHelper
{
    public class Drawer
    {
        public List<int> positionX = new List<int>();
        public List<int> positionY = new List<int>();

        public CustomizedPanel Draw(Panel canvas, string shape, Color color,float angle)
        {
            //the shape is passed to be drawn 
            CustomizedPanel panel = new CustomizedPanel(shape,color,angle);

            //panel size
            panel.Width = 50;
            panel.Height = 50;

            int panelX;
            int panelY;
            //panel position
            Random random = new Random();
            
            panelX = random.Next(0, canvas.Width - panel.Width);
            panelY = random.Next(0, canvas.Height - panel.Height);
            while (positionX.Contains(panelX) && positionY.Contains(panelY))
            {
              panelX = random.Next(0, canvas.Width - panel.Width);
              panelY = random.Next(0, canvas.Height - panel.Height);

              positionX.Add(panelX);
              positionY.Add(panelY);
            }

            panel.Location = new Point(panelX,panelY);

            canvas.Controls.Add(panel);

            return panel;
        }

    }
}
