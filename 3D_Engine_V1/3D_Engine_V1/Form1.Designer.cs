namespace _3D_3ngine_V1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.ZrotLabel = new System.Windows.Forms.Label();
            this.XrotLabel = new System.Windows.Forms.Label();
            this.YrotLabel = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBarTrX = new System.Windows.Forms.TrackBar();
            this.trackBarTrY = new System.Windows.Forms.TrackBar();
            this.trackBarTrZ = new System.Windows.Forms.TrackBar();
            this.YTrLabel = new System.Windows.Forms.Label();
            this.TrXlabel = new System.Windows.Forms.Label();
            this.TrZlabel = new System.Windows.Forms.Label();
            this.canvasTimer = new System.Windows.Forms.Timer(this.components);
            this.Record_BTN = new System.Windows.Forms.Button();
            this.Add_OBJ = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Play_BTN = new System.Windows.Forms.Button();
            this.Stop_BTN = new System.Windows.Forms.Button();
            this.Record_Timer = new System.Windows.Forms.Timer(this.components);
            this.Play_Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrZ)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(109, 7);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1140, 437);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(40, 10);
            this.scaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(37, 15);
            this.scaleLabel.TabIndex = 16;
            this.scaleLabel.Text = "Scale:";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(90, 53);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(482, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(90, 106);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(480, 45);
            this.trackBar2.TabIndex = 18;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // ZrotLabel
            // 
            this.ZrotLabel.AutoSize = true;
            this.ZrotLabel.Location = new System.Drawing.Point(17, 151);
            this.ZrotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZrotLabel.Name = "ZrotLabel";
            this.ZrotLabel.Size = new System.Drawing.Size(62, 15);
            this.ZrotLabel.TabIndex = 21;
            this.ZrotLabel.Text = "Z rotation:";
            // 
            // XrotLabel
            // 
            this.XrotLabel.AutoSize = true;
            this.XrotLabel.Location = new System.Drawing.Point(15, 97);
            this.XrotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XrotLabel.Name = "XrotLabel";
            this.XrotLabel.Size = new System.Drawing.Size(62, 15);
            this.XrotLabel.TabIndex = 20;
            this.XrotLabel.Text = "X rotation:";
            // 
            // YrotLabel
            // 
            this.YrotLabel.AutoSize = true;
            this.YrotLabel.Location = new System.Drawing.Point(15, 55);
            this.YrotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YrotLabel.Name = "YrotLabel";
            this.YrotLabel.Size = new System.Drawing.Size(62, 15);
            this.YrotLabel.TabIndex = 19;
            this.YrotLabel.Text = "Y rotation:";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(89, 157);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(481, 45);
            this.trackBar3.TabIndex = 22;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(89, 5);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar4.Maximum = 150;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(1117, 45);
            this.trackBar4.TabIndex = 23;
            this.trackBar4.Value = 1;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBarTrX
            // 
            this.trackBarTrX.Location = new System.Drawing.Point(683, 106);
            this.trackBarTrX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarTrX.Maximum = 50;
            this.trackBarTrX.Minimum = -50;
            this.trackBarTrX.Name = "trackBarTrX";
            this.trackBarTrX.Size = new System.Drawing.Size(523, 45);
            this.trackBarTrX.TabIndex = 24;
            this.trackBarTrX.Value = 4;
            this.trackBarTrX.Scroll += new System.EventHandler(this.trackBarTrX_Scroll);
            // 
            // trackBarTrY
            // 
            this.trackBarTrY.Location = new System.Drawing.Point(683, 55);
            this.trackBarTrY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarTrY.Maximum = 50;
            this.trackBarTrY.Minimum = -50;
            this.trackBarTrY.Name = "trackBarTrY";
            this.trackBarTrY.Size = new System.Drawing.Size(523, 45);
            this.trackBarTrY.TabIndex = 25;
            this.trackBarTrY.Scroll += new System.EventHandler(this.trackBarTrY_Scroll);
            // 
            // trackBarTrZ
            // 
            this.trackBarTrZ.Location = new System.Drawing.Point(683, 157);
            this.trackBarTrZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarTrZ.Maximum = 50;
            this.trackBarTrZ.Minimum = -50;
            this.trackBarTrZ.Name = "trackBarTrZ";
            this.trackBarTrZ.Size = new System.Drawing.Size(523, 45);
            this.trackBarTrZ.TabIndex = 26;
            this.trackBarTrZ.Value = 7;
            this.trackBarTrZ.Scroll += new System.EventHandler(this.trackBarTrZ_Scroll);
            // 
            // YTrLabel
            // 
            this.YTrLabel.AutoSize = true;
            this.YTrLabel.Location = new System.Drawing.Point(580, 55);
            this.YTrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YTrLabel.Name = "YTrLabel";
            this.YTrLabel.Size = new System.Drawing.Size(77, 15);
            this.YTrLabel.TabIndex = 27;
            this.YTrLabel.Text = "Y Translation:";
            this.YTrLabel.Click += new System.EventHandler(this.YTrLabel_Click);
            // 
            // TrXlabel
            // 
            this.TrXlabel.AutoSize = true;
            this.TrXlabel.Location = new System.Drawing.Point(580, 94);
            this.TrXlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrXlabel.Name = "TrXlabel";
            this.TrXlabel.Size = new System.Drawing.Size(77, 15);
            this.TrXlabel.TabIndex = 28;
            this.TrXlabel.Text = "X Translation:";
            this.TrXlabel.Click += new System.EventHandler(this.TrXlabel_Click);
            // 
            // TrZlabel
            // 
            this.TrZlabel.AutoSize = true;
            this.TrZlabel.Location = new System.Drawing.Point(577, 145);
            this.TrZlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrZlabel.Name = "TrZlabel";
            this.TrZlabel.Size = new System.Drawing.Size(80, 15);
            this.TrZlabel.TabIndex = 29;
            this.TrZlabel.Text = "Z Translation::";
            this.TrZlabel.Click += new System.EventHandler(this.TrZlabel_Click);
            // 
            // canvasTimer
            // 
            this.canvasTimer.Interval = 1;
            this.canvasTimer.Tick += new System.EventHandler(this.canvasTimer_Tick);
            // 
            // Record_BTN
            // 
            this.Record_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Record_BTN.BackColor = System.Drawing.Color.Red;
            this.Record_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Record_BTN.Location = new System.Drawing.Point(15, 355);
            this.Record_BTN.Name = "Record_BTN";
            this.Record_BTN.Size = new System.Drawing.Size(74, 28);
            this.Record_BTN.TabIndex = 31;
            this.Record_BTN.Text = "Record";
            this.Record_BTN.UseVisualStyleBackColor = false;
            this.Record_BTN.Click += new System.EventHandler(this.Record_BTN_Click);
            // 
            // Add_OBJ
            // 
            this.Add_OBJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_OBJ.BackColor = System.Drawing.Color.Green;
            this.Add_OBJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_OBJ.Location = new System.Drawing.Point(16, 5);
            this.Add_OBJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Add_OBJ.Name = "Add_OBJ";
            this.Add_OBJ.Size = new System.Drawing.Size(74, 92);
            this.Add_OBJ.TabIndex = 32;
            this.Add_OBJ.Text = "Add OBJ file";
            this.Add_OBJ.UseVisualStyleBackColor = false;
            this.Add_OBJ.Click += new System.EventHandler(this.Add_OBJ_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(15, 100);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(75, 219);
            this.treeView1.TabIndex = 33;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // Play_BTN
            // 
            this.Play_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Play_BTN.BackColor = System.Drawing.Color.Green;
            this.Play_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Play_BTN.Location = new System.Drawing.Point(15, 389);
            this.Play_BTN.Name = "Play_BTN";
            this.Play_BTN.Size = new System.Drawing.Size(74, 30);
            this.Play_BTN.TabIndex = 35;
            this.Play_BTN.Text = "Play";
            this.Play_BTN.UseVisualStyleBackColor = false;
            this.Play_BTN.Click += new System.EventHandler(this.Play_BTN_Click);
            // 
            // Stop_BTN
            // 
            this.Stop_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stop_BTN.Location = new System.Drawing.Point(15, 325);
            this.Stop_BTN.Name = "Stop_BTN";
            this.Stop_BTN.Size = new System.Drawing.Size(74, 24);
            this.Stop_BTN.TabIndex = 36;
            this.Stop_BTN.Text = "Stop";
            this.Stop_BTN.UseVisualStyleBackColor = true;
            this.Stop_BTN.Click += new System.EventHandler(this.Stop_BTN_Click);
            // 
            // Record_Timer
            // 
            this.Record_Timer.Tick += new System.EventHandler(this.Record_Timer_Tick);
            // 
            // Play_Timer
            // 
            this.Play_Timer.Tick += new System.EventHandler(this.Play_Timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TrZlabel);
            this.panel1.Controls.Add(this.TrXlabel);
            this.panel1.Controls.Add(this.YTrLabel);
            this.panel1.Controls.Add(this.trackBar4);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.trackBar3);
            this.panel1.Controls.Add(this.trackBarTrX);
            this.panel1.Controls.Add(this.trackBarTrY);
            this.panel1.Controls.Add(this.ZrotLabel);
            this.panel1.Controls.Add(this.XrotLabel);
            this.panel1.Controls.Add(this.trackBarTrZ);
            this.panel1.Controls.Add(this.YrotLabel);
            this.panel1.Controls.Add(this.scaleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 199);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Add_OBJ);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.Record_BTN);
            this.panel2.Controls.Add(this.Stop_BTN);
            this.panel2.Controls.Add(this.Play_BTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 450);
            this.panel2.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1249, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PCT_CANVAS);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "DEMO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrZ)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label ZrotLabel;
        private System.Windows.Forms.Label XrotLabel;
        private System.Windows.Forms.Label YrotLabel;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBarTrX;
        private System.Windows.Forms.TrackBar trackBarTrY;
        private System.Windows.Forms.TrackBar trackBarTrZ;
        private Label YTrLabel;
        private Label TrXlabel;
        private Label TrZlabel;
        private System.Windows.Forms.Timer canvasTimer;
        private Button Record_BTN;
        private Button Add_OBJ;
        private TreeView treeView1;
        private Button Play_BTN;
        private Button Stop_BTN;
        private System.Windows.Forms.Timer Record_Timer;
        private System.Windows.Forms.Timer Play_Timer;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
    }
}
