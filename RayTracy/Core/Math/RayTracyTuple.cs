using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Core.Math
{
    public class RayTracyTuple
    {
        public Double X { get; set; }
        public Double Y { get; set; }
        public Double Z { get; set; }
        public Double W { get; set; }
        public bool IsPoint => W == 1.0d;

        public bool IsVector => W == 0.0d;
    }
}
