namespace edge_RGB
{
    partial class R
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.原画像 = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(110, 12);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(246, 264);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.Click += new System.EventHandler(this.OnClick_Picturebox1);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(0, 12);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(64, 19);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.ValueChanged_TB1);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(0, 37);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(64, 19);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 50;
            this.trackBar2.ValueChanged += new System.EventHandler(this.ValueChanged_TB2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.TextChanged_Box1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 19);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "50";
            this.textBox2.TextChanged += new System.EventHandler(this.TextChanged_Box2);
            // 
            // 原画像
            // 
            this.原画像.Location = new System.Drawing.Point(13, 63);
            this.原画像.Name = "原画像";
            this.原画像.Size = new System.Drawing.Size(75, 23);
            this.原画像.TabIndex = 5;
            this.原画像.Text = "原画像";
            this.原画像.UseVisualStyleBackColor = true;
            this.原画像.Click += new System.EventHandler(this.OnClick原画像);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(47, 92);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(28, 19);
            this.y.TabIndex = 8;
            this.y.Text = "y";
            this.y.TextChanged += new System.EventHandler(this.TextChanged_y);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(13, 92);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(28, 19);
            this.x.TabIndex = 7;
            this.x.Text = "x";
            this.x.TextChanged += new System.EventHandler(this.TextChanged_x);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "(R,G,B)";
            // 
            // R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(368, 288);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.原画像);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "R";
            this.Text = "R";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button 原画像;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label1;
    }
}