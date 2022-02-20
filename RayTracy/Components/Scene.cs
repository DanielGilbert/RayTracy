using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Components
{
    public class Scene
    {
        public Camera Camera { get; set; }

        public Scene(Camera camera)
        {
            Camera = camera;
        }
    }
}
