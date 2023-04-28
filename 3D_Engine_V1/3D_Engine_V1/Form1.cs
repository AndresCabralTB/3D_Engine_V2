using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3D_3ngine_V1
{
    public partial class Form1 : Form
    {

        public float z = 1f;

        public float rotateY = 0.0f;
        public float rotateX = 0.0f;
        public float rotateZ = 0.0f;

        public float translateX = 3.0f;
        public float translateY = -1.0f;
        public float translateZ = 20.0f;

        Vertex vert = new Vertex();
        Vertex translate = new Vertex();

        public List<Vertex> rotationValues = new List<Vertex>();
        public List<Vertex> traslationValues = new List<Vertex>();
        public List<float> zValues = new List<float>();

        public TreeNode selectedNode;
        public int count = 2;
        public int playbackIndex = 0;

        public bool objSel = true;

        string filename;
        string filename2;
        string filename3;

        //filename2;
        public Form1()
        {
            InitializeComponent();
        }
        public void Init(string filename, string filename2, string filename3)
        {
            //canvasTimer.Start();
            //canvasTimer.Enabled = true;
            //canvasTimer.Interval = 1;

            CreateNewOBJ(filename, filename2, filename3);
            PCT_CANVAS.Invalidate();
        }

        public void CreateNewOBJ(string filename, string filename2, string filename3)
        {
            ObjParser objectPar = new ObjParser(filename);
            ObjParser objectPar2 = new ObjParser(filename2);
            ObjParser objectPar3 = new ObjParser(filename3);


            vert = new Vertex(trackBar2.Value, trackBar1.Value, trackBar3.Value);
            translate = new Vertex(trackBarTrX.Value, trackBarTrY.Value, trackBarTrZ.Value);

            //-----------------FIRST OBJECT--------------------------//
            Vertex[] vertices = objectPar.Vertices.Select(v => new Vertex(v[0], v[1], v[2])).ToArray();

            Triangle[] triangles = objectPar.Faces.Select(t => new Triangle(
                Array.IndexOf(vertices, vertices[t[0]]),
                Array.IndexOf(vertices, vertices[t[1]]),
                Array.IndexOf(vertices, vertices[t[2]]),
                Color.Black)).ToArray();

            Model cube = new Model(vertices, triangles, new Vertex(0, 0, 0), (float)Math.Sqrt(3));

            //-----------------SECOND OBJECT--------------------------//
            Vertex[] vertices2 = objectPar2.Vertices.Select(v => new Vertex(v[0], v[1], v[2])).ToArray();

            Triangle[] triangles2 = objectPar2.Faces.Select(t => new Triangle(
                Array.IndexOf(vertices, vertices[t[0]]),
                Array.IndexOf(vertices, vertices[t[1]]),
                Array.IndexOf(vertices, vertices[t[2]]),
                Color.Black)).ToArray();

            Model cube2 = new Model(vertices2, triangles2, new Vertex(0, 0, 0), (float)Math.Sqrt(3));

            //-----------------THIRD OBJECT--------------------------//
            Vertex[] vertices3 = objectPar3.Vertices.Select(v => new Vertex(v[0], v[1], v[2])).ToArray();

            Triangle[] triangles3 = objectPar3.Faces.Select(t => new Triangle(
                Array.IndexOf(vertices, vertices[t[0]]),
                Array.IndexOf(vertices, vertices[t[1]]),
                Array.IndexOf(vertices, vertices[t[2]]),
                Color.Black)).ToArray();

            Model cube3 = new Model(vertices3, triangles3, new Vertex(0, 0, 0), (float)Math.Sqrt(3));

            Instance[] instances = new Instance[count + 1];


            /*
            for (int i = 0; i <= count; i++)
            {
                instances[i] = new Instance(cube, translate, Mtx.Rotate(vert), trackBar4.Value);
                instances[i] = new Instance(cube, translate, Mtx.Rotate(vert), trackBar4.Value);
                //instances[i].position = translate;
            } */

            
           instances[0] = new Instance(cube, translate, Mtx.Rotate(vert), trackBar4.Value);
           instances[1] = new Instance(cube2, new Vertex(trackBarTrX.Value - 5f, trackBarTrY.Value, trackBarTrZ.Value), Mtx.Rotate(vert), trackBar4.Value);
           instances[2] = new Instance(cube3, new Vertex(trackBarTrX.Value + 5f, trackBarTrY.Value, trackBarTrZ.Value), Mtx.Rotate(vert), trackBar4.Value);

            Rasterization raster = new Rasterization(PCT_CANVAS.Size, vert, translate, trackBar4.Value, instances, count);


           PCT_CANVAS.Image = raster.Canvas;
            // PCT_CANVAS.Invalidate();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                selectedNode = e.Node;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        //List<string> objFiles = new List<string>();

        public void Add_OBJ_Click(object sender, EventArgs e)
        { 

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "OBJ files (*.obj)|*.obj";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileNames.Length == 3)
                {


                    filename = dialog.FileNames[0];
                    filename2 = dialog.FileNames[1];
                    filename3 = dialog.FileNames[2];


                    //Add tree view
                    TreeNode parentNode = treeView1.Nodes.Add("Selected OBJ files");
                    TreeNode node1 = parentNode.Nodes.Add(filename);
                    TreeNode node2 = parentNode.Nodes.Add(filename2);
                    TreeNode node3 = parentNode.Nodes.Add(filename3);

                    Init(filename, filename2, filename3);
                    // Do something with objectPar and objectPar2
                }
                else
                {
                    MessageBox.Show("Please select two OBJ files.");
                }
            }

            
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            rotateY = trackBar1.Value;
            YrotLabel.Text = "Y:" + rotateY.ToString();

            //string filename = selectedNode.Tag.ToString();

            // Init(selectedNode.Tag.ToString());
            Init(filename, filename2, filename3);

        }

        public void trackBar2_Scroll(object sender, EventArgs e)
        {

            rotateX = trackBar2.Value;
            XrotLabel.Text = "X:" + rotateX.ToString();

            // string filename = selectedNode.Tag.ToString();

            // Init(selectedNode.Tag.ToString());
            // PCT_CANVAS.Invalidate();

            //Init(filename, filename2);

            Init(filename, filename2, filename3);
        }

        public void trackBar3_Scroll(object sender, EventArgs e)
        {
            rotateZ = trackBar3.Value;
            ZrotLabel.Text = "Z:" + rotateZ.ToString();

            //string filename = selectedNode.Tag.ToString();

            //Init(selectedNode.Tag.ToString());
            // PCT_CANVAS.Invalidate();

            // Init(filename, filename2);
            Init(filename, filename2, filename3);
        }

        public void trackBar4_Scroll(object sender, EventArgs e)
        {
            
            z = trackBar4.Value;
            scaleLabel.Text = "Scale:" + z.ToString();

            //string filename = selectedNode.Tag.ToString();

            // Init(selectedNode.Tag.ToString());
            // PCT_CANVAS.Invalidate();

            //Init(filename, filename2);
            Init(filename, filename2, filename3);
        }

        public void trackBarTrY_Scroll(object sender, EventArgs e)
        {
            translateY = trackBarTrY.Value;
            YTrLabel.Text ="Y:" + translateY.ToString();

            //string filename = selectedNode.Tag.ToString();

            //Init(selectedNode.Tag.ToString());
            // PCT_CANVAS.Invalidate();

            //Init(filename, filename2);
            Init(filename, filename2, filename3);
        }

        public void trackBarTrX_Scroll(object sender, EventArgs e)
        {
            translateX = trackBarTrX.Value;
            TrXlabel.Text = "X:" + translateX.ToString();

            // string filename = selectedNode.Tag.ToString();

            //Init(selectedNode.Tag.ToString());
            // PCT_CANVAS.Invalidate();

            //Init(filename, filename2);
            Init(filename, filename2, filename3);

        }

        public void trackBarTrZ_Scroll(object sender, EventArgs e)
        {
            translateZ = trackBarTrZ.Value;
            TrZlabel.Text = "Z: " + translateZ.ToString();
            // string filename = selectedNode.Tag.ToString();

            //Init(selectedNode.Tag.ToString());
            // PCT_CANVAS.Invalidate();

            //Init(filename, filename2);
            Init(filename, filename2, filename3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void canvasTimer_Tick(object sender, EventArgs e)
        {
            PCT_CANVAS.Invalidate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            canvasTimer.Stop();
        }

        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            /*
            savedTranslate = new Vertex(trackBarTrX.Value, trackBarTrY.Value, trackBarTrZ.Value);

            trackBarTrX.Value = -3;
            trackBarTrY.Value = 0;
            trackBarTrZ.Value = 8;

            //rotationValues.Clear();
            objSel = !objSel;
            Init(selectedNode.Tag.ToString());

            */
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        public void Record_BTN_Click(object sender, EventArgs e)
        {
            Record_Timer.Interval = 50; //100
            Record_Timer.Start();
            Record_Timer.Enabled = true;
            Record_BTN.Enabled = false;

            //trackbarValues.Clear();

            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 10000; 
        }

        private void Record_Timer_Tick(object sender, EventArgs e)
        {
            vert = new Vertex(trackBar2.Value, trackBar1.Value, trackBar3.Value);
            translate = new Vertex(trackBarTrX.Value, trackBarTrY.Value, trackBarTrZ.Value);
            z = trackBar4.Value;

            rotationValues.Add(vert);
            traslationValues.Add(translate);
            zValues.Add(z);
        }

        public void Play_BTN_Click(object sender, EventArgs e)
        {
            Play_Timer.Interval = 50; //125
            Play_Timer.Start();
            //Play_Timer.Tick += Play_Timer_Tick;
        }

        public void Play_Timer_Tick(object sender, EventArgs e)
        {
            if(playbackIndex < rotationValues.Count)
            {
                trackBar2.Value = (int)rotationValues[playbackIndex].X;
                trackBar1.Value = (int)rotationValues[playbackIndex].Y;
                trackBar3.Value = (int)rotationValues[playbackIndex].Z;

                trackBarTrX.Value = (int)traslationValues[playbackIndex].X;
                trackBarTrY.Value = (int)traslationValues[playbackIndex].Y;
                trackBarTrZ.Value = (int)traslationValues[playbackIndex].Z;

                trackBar4.Value = (int)zValues[playbackIndex];

                //string filename = selectedNode.Tag.ToString();

                //Init(filename, filename2);
                Init(filename, filename2, filename3);
                // PCT_CANVAS.Invalidate();
                playbackIndex++;
            }
            else
            {
                playbackIndex = 0;
                Play_Timer.Stop();
                Play_Timer.Enabled = false;
                Record_BTN.Enabled = true;
                
                MessageBox.Show("End of recording");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This runs 5 seconds after the Record Button is clicked
            Record_Timer.Stop();
            Record_Timer.Enabled = false;
            Record_BTN.Enabled = true;

            timer1.Stop();
            timer1.Enabled = false;
            MessageBox.Show("Screen has stopped recording");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YTrLabel_Click(object sender, EventArgs e)
        {

        }

        private void TrXlabel_Click(object sender, EventArgs e)
        {

        }

        private void TrZlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
