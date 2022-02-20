using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RayTracy.Drawing.Factories
{
    public static class Rgba32Factory
    {
        public static Rgba32 FromNormalizedVector3(Vector3 sourceVector)
        {
            return new Rgba32(sourceVector.X, sourceVector.Y, sourceVector.Z);
        }

        public static Rgba32 FromNormalizedComponents(float x, float y, float z)
        {
            return new Rgba32(x, y, z);
        }
    }
}
