using RayTracy.Drawing;
using RayTracy.Drawing.Factories;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

int width = 640;
int height = 480;

ImageWriter imageWriter = new();

Rgba32[,] data = new Rgba32[width, height];

for(int y = 0; y < height ; y++)
    for(int x = 0; x < width; x++)
    {
        float r = (float)x / (float)(width - 1);
        float g = 1.0f - ((float)y / (float)(height - 1));
        float b = 0.25f;

        data[x, y] = Rgba32Factory.FromNormalizedComponents(r, g, b);
    }

imageWriter.WriteImage("test.bmp", 480, 640, data);
imageWriter.TestImage("test2.bmp", 480, 640);