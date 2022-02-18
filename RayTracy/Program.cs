using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

int width = 640;
int height = 480;

using (Image<Rgba32> image = new(width, height))
{
    Console.WriteLine("Start writing image..");
    for (int x = 0; x < width; x++)
        for (int y = 0; y < height; y++)
        {
            image[x, y] = new Rgba32(0, 255, 255, 255);
        }

    image.SaveAsBmp("test.bmp");
    Console.WriteLine("Image saved.");
}