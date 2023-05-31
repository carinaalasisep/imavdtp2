using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVDTP2.CropperHelper
{
    public class Cropper
    {
        public static void ApplyCroppedImageToPanel(Panel panel,string option)
        {
            Bitmap croppedImage = CropPanelCorner(panel,option);

            // Set the cropped image as the background image of the panel
            panel.BackgroundImage = croppedImage;

            // Refresh the panel to update the displayed image
            panel.Invalidate();
        }

        private static Bitmap CropPanelCorner(Panel panel,string option)
        {
            var resultBitmap = new Bitmap(panel.Width, panel.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                // Capture the content of the panel
                panel.DrawToBitmap(resultBitmap, new Rectangle(0, 0, panel.Width, panel.Height));
            }

            // Define the region to crop (triangular regions)
            int cropStartX = panel.Width;
            int cropStartY = panel.Height;

            if (option == "lower right corner")
            {
                // Crop the top left part (top-left triangle) by setting the pixels to transparent
                for (int y = 0; y < cropStartY; y++)
                {
                    for (int x = 0; x < cropStartX - y; x++)
                    {
                        Color pixelColor = resultBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(x, y, Color.FromArgb(0, pixelColor.R, pixelColor.G, pixelColor.B));

                    }
                }
            }

            if (option == "upper left corner")
            {

                for (int y = 0; y < cropStartY; y++)
                {
                    for(int x = 0;x< cropStartX; x++)
                    {
                        Color pixelColor = resultBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(x, y, Color.FromArgb(0, pixelColor.R, pixelColor.G, pixelColor.B));
                    }
                }
                
                // Save the top left part
                for (int y = 0; y < cropStartY; y++)
                {
                    for (int x = 0; x < cropStartX - y; x++)
                    {
                        Color pixelColor = resultBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(x, y, Color.FromArgb(255, pixelColor.R, pixelColor.G, pixelColor.B));
                    }
                }
            }

            return resultBitmap;
        }



    }
}
