using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _3D_3ngine_V1
{
    public class Instance
    {
        public Model model;
        public Vertex position;
        public Mtx orientation;
        public float scale;
        public Mtx transform;

        public Instance(Model model, Vertex position, Mtx orientation = null, float scale = 1.0f)
        {
            this.model = model;
            this.position = position;
            this.orientation = orientation ?? Mtx.Identity;
            this.scale = scale;

            this.transform = Mtx.MakeTranslationMatrix(this.position) * this.orientation * Mtx.MakeScalingMatrix(this.scale);
        }
    }
}
