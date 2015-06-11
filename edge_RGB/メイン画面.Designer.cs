namespace edge_RGB
{
    partial class メイン画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.開く = new System.Windows.Forms.Button();
            this.合成 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(93, 12);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(292, 296);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.Click += new System.EventHandler(this.OnClick_PictureboxIpl1);
            // 
            // 開く
            // 
            this.開く.Location = new System.Drawing.Point(12, 12);
            this.開く.Name = "開く";
            this.開く.Size = new System.Drawing.Size(75, 23);
            this.開く.TabIndex = 1;
            this.開く.Text = "開く";
            this.開く.UseVisualStyleBackColor = true;
            this.開く.Click += new System.EventHandler(this.OnClick開く);
            // 
            // 合成
            // 
            this.合成.Location = new System.Drawing.Point(12, 41);
            this.合成.Name = "合成";
            this.合成.Size = new System.Drawing.Size(75, 23);
            this.合成.TabIndex = 2;
            this.合成.Text = "合成";
            this.合成.UseVisualStyleBackColor = true;
            this.合成.Click += new System.EventHandler(this.OnClick合成);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "(R,G,B)";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(13, 71);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(28, 19);
            this.x.TabIndex = 4;
            this.x.Text = "x";
            this.x.TextChanged += new System.EventHandler(this.Text_Changed_x);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(47, 71);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(28, 19);
            this.y.TabIndex = 5;
            this.y.Text = "y";
            this.y.TextChanged += new System.EventHandler(this.TextChanged_y);
            // 
            // メイン画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(391, 315);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.合成);
            this.Controls.Add(this.開く);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "メイン画面";
            this.Text = "メイン画面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Button 開く;
        private System.Windows.Forms.Button 合成;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
    }
}

