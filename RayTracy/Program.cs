using RayTracy.Components;
using RayTracy.Components.Factories;
using RayTracy.Drawing.Factories;
using RayTracy.Drawing.Writers;
using RayTracy.Helpers;
using RayTracy.Rendering;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Diagnostics;
using System.Numerics;

string filePath = "test.bmp";
int width = 1920;
int height = 1080;

Camera camera = CameraFactory.CreateDefaultCamera(width, height);
Scene scene = new (camera);
SceneTracer sceneTracer = new ();

Rgba32[,] data = sceneTracer.Trace(scene, width, height);

using (ImageWriter imageWriter = new())
{
    imageWriter.WriteImage(filePath, width, height, data);
}

LaunchHelper.Launch(filePath);