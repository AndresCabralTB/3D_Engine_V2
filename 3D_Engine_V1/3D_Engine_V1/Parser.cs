using _3D_3ngine_V1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;

namespace _3D_3ngine_V1
{
    public class ObjParser
    {
        public List<float[]> Vertices { get; private set; }
        public List<int[]> Faces { get; private set; }


        Instance instances;
        Model model;
        bool semi = false;
        float scale = 0.75f;

        public ObjParser(string filename)
        {

            Vertices = new List<float[]>();
            Faces = new List<int[]>();

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (tokens[0] == "v")
                    {
                        float[] vertex = new float[3];

                        for (int i = 0; i < 3; i++)
                        {
                            vertex[i] = float.Parse(tokens[i + 1]);
                        }

                        Vertices.Add(vertex);
                    }
                    else if (tokens[0] == "f")
                    {
                        int[] face = new int[3];

                        for (int i = 0; i < 3; i++)
                        {
                            string[] subtokens = tokens[i + 1].Split('/');
                            face[i] = int.Parse(subtokens[0]) - 1;  // subtract 1 to convert to zero-based indexing
                        }

                        Faces.Add(face);
                    }
                }
            }
        }

        /* public void openFile()
         {
             OpenFileDialog openFileDialog = new OpenFileDialog();
             Vertex[] vertices;
             Triangle[] triangles;

             openFileDialog.Filter = "OBJ files (*.obj)|*.obj";

             string newFileName = openFileDialog.FileName;

             using (StreamReader sr = new StreamReader(newFileName))
             {
                 string line2;

                 while ((line2 = sr.ReadLine()) != null)
                 {
                     string[] tokens = line2.Split(' ');

                     if (line2.StartsWith("v"))
                     {
                         string[] vertexVal = line2.Split(' ');
                         verticesVals.Add(new Vertex(float.Parse(vertexVal[1]), float.Parse(vertexVal[2]), float.Parse(vertexVal[3])));


                     }
                     else if (line2.StartsWith("f"))
                     {
                         if (line2.Contains('/'))
                         {
                             string[] spaces = line2.Split(' ');
                             string[] triaValues = new string[3];

                             for (int i = 0; i < spaces.Length - 1; i++)
                             {
                                 string[] diagonals = spaces[i + 1].Split('/');
                                 triaValues[i] = diagonals[0];
                             }

                             triangleVals.Add(new Triangle(int.Parse(triaValues[0]) - 1, int.Parse(triaValues[1]) - 1, int.Parse(triaValues[2]) - 1, Color.Yellow));
                         }
                         else
                         {
                             string[] triaValues = line2.Split(' ');
                             triangleVals.Add(new Triangle(int.Parse(triaValues[1]) - 1, int.Parse(triaValues[2]) - 1, int.Parse(triaValues[3]) - 1, Color.Yellow));
                         }
                     }
                 }

                 vertices = verticesVals.ToArray();
                 triangles = triangleVals.ToArray();

                 RenderFigures(vertices, triangles);
             }
         }

         private void RenderFigures(Vertex[] vertices, Triangle[] triangles)
         {
             model = new Model(vertices, triangles);
             instances = new Instance[1];
             instances[0] = new Instance(model, new Vertex(0, 0, 8), Mtx.Identity, scale);
         } */
    }
}



