using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IMAVDTP2.DrawerHelper
{
    public class Drawer
    {
        public static void Draw(Panel canvas, string shape, Color color)
        {
            //the shape is passed to be drawn 
            Panel panel = new CustomizedPanel(shape,color);

            //panel size
            panel.Width = 50;
            panel.Height = 50;

            //panel position
            Random random = new Random();
            int panelX = random.Next(0,canvas.Width-panel.Width);
            int panelY = random.Next(0,canvas.Height-panel.Height);

            panel.Location = new Point(panelX,panelY);

            canvas.Controls.Add(panel);
        }

    }
}
