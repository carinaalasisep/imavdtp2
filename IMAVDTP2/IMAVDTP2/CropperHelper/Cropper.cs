using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVDTP2.CropperHelper
{
    public class Cropper
    {
        public static void ApplyCroppedImageToPanel(PictureBox pictureBox, string option)
        {
            Bitmap croppedImage = CropPictureBoxCorner(pictureBox, option);

            pictureBox.Image = croppedImage;

            pictureBox.Refresh();
        }

        private static Bitmap CropPictureBoxCorner(PictureBox pictureBox, string option)
        {
            var resultBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                // Captura o conteúdo da picture box
                pictureBox.DrawToBitmap(resultBitmap, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            }

            // Define a região para recortar (regiões triangulares)
            int cropStartX = pictureBox.Width;
            int cropStartY = pictureBox.Height;

            if (option == "lower right corner")
            {
                // Recorta a parte superior esquerda (triângulo superior esquerdo), definindo os pixels como transparentes
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
                    for (int x = 0; x < cropStartX; x++)
                    {
                        Color pixelColor = resultBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(x, y, Color.FromArgb(0, pixelColor.R, pixelColor.G, pixelColor.B));
                    }
                }

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
