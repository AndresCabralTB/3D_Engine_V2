using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _3D_3ngine_V1
{
    public class Camera
    {
        public Vertex position;
        public Mtx orientation;
        public List<Plane> clipping_planes;

        public Camera(Vertex position, Mtx orientation)
        {
            this.position = position;
            this.orientation = orientation;
            this.clipping_planes = new List<Plane>();
        }

        public override string ToString()
        {
            return position.ToString();
        }
    }
}
