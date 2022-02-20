using RayTracy.Drawing.Factories;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Drawing
{
    public class ImageWriter
    {
        public void TestImage(string path, int imageHeight, int imageWidth)
        {
            using (Image<Rgba32> image = new(imageWidth, imageHeight))
            {
                image[0, imageHeight - 1] = new Rgba32(255, 0, 0);
                image[imageWidth - 1, 0] = new Rgba32(0, 255, 0);
                image[imageWidth - 1, imageHeight - 1] = new Rgba32(0, 0, 255);

                image.SaveAsBmp(path);
            }
        }

        public void WriteImage(string path, int imageHeight, int imageWidth, Rgba32[,] data)
        {
            using (Image<Rgba32> image = new(imageWidth, imageHeight))
            {
                for (int y = 0; y < imageHeight; y++)
                    for (int x = 0; x < imageWidth; x++)
                    {
                        image[x, y] = data[x,y];
                    }

                image.SaveAsBmp(path);
            }
        }

        public void WriteImage(string path, int imageHeight, int imageWidth, Vector3[,] data)
        {
            using (Image<Rgba32> image = new(imageWidth, imageHeight))
            {
                for (int y = 0; y < imageHeight; y++)
                    for (int x = 0; x < imageWidth; x++)
                    {
                        image[x, y] = Rgba32Factory.FromNormalizedVector3(data[x, y]);
                    }

                image.SaveAsBmp(path);
            }
        }
    }
}