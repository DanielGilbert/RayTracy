using RayTracy.Components;
using RayTracy.Math;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Rendering
{
    public class SceneTracer
    {
        private Vector3 _whiteColor;
        private Vector3 _skyColor;

        public SceneTracer()
        {
            _whiteColor = new Vector3(1.0f, 1.0f,1.0f);
            _skyColor = new Vector3(0.5f, 0.7f, 1.0f);
        }

        private Rgba32 RayColor(Ray ray)
        {
            Vector3 unitDirection = Vector3.Normalize(ray.Direction);
            float t = 0.5f * (unitDirection.Y + 1.0f);
            return new Rgba32((1.0f - t) * _skyColor + t * _whiteColor);
        }

        public Rgba32[,] Trace(Scene scene, int width, int height)
        {
            Rgba32[,] data = new Rgba32[width, height];

            for(int y = 0; y < height; y++)
                for(int x = 0; x < width; x++)
                {
                    float u = x / (float)(width - 1.0f);
                    float v = y / (float)(height - 1.0f);

                    Camera camera = scene.Camera;
                    Ray ray = new Ray(camera.Position, camera.LowerLeftCorner + u * camera.HorizontalVector3 + v * camera.VerticalVector3 - camera.Position);
                    data[x, y] = RayColor(ray);
                }

            return data;
        }
    }
}
