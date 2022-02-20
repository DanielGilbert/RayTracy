using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Components.Factories
{
    public static class CameraFactory
    {
        public static Camera CreateDefaultCamera(int width, int height)
        {
            return new(new Vector3(0.0f, 0.0f, 0.0f), 1.0f, width, height);
        }
    }
}
