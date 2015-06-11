using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharp;

namespace edge_RGB
{
    public partial class R : Form
    {
        private static R _instance;
        public static IplImage Canny_R;
        
        public R()
        {
            InitializeComponent();
            Canny_R = メイン画面.入力画像_RGB[0].Clone();
            canny実行();
        }

        public static R Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                    _instance = new R();
                return _instance;
            }
        }

        private void canny実行()
        {
            メイン画面.入力画像_RGB[0].Canny(Canny_R,trackBar1.Value,trackBar2.Value);
            画像表示(Canny_R);
        }
        private void 画像表示(IplImage src)
        {
            pictureBoxIpl1.Width=src.Width;
            pictureBoxIpl1.Height = src.Height;
            pictureBoxIpl1.ImageIpl = src;

        }

        private void ValueChanged_TB1(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            canny実行();
        }

        private void ValueChanged_TB2(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            canny実行();
        }

        private void TextChanged_Box1(object sender, EventArgs e)
        {
            int isnumber;
            if (int.TryParse(textBox1.Text, out isnumber))
                if (isnumber >= trackBar1.Minimum && isnumber <= trackBar1.Maximum)
                    trackBar1.Value = isnumber;
        }

        private void TextChanged_Box2(object sender, EventArgs e)
        {
            int isnumber;
            if (int.TryParse(textBox2.Text, out isnumber))
                if (isnumber >= trackBar2.Minimum && isnumber <= trackBar2.Maximum)
                    trackBar2.Value = isnumber;
        }

        private void OnClick原画像(object sender, EventArgs e)
        {
            画像表示(メイン画面.入力画像_RGB[0]);
        }

        private void OnClick_Picturebox1(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                System.Drawing.Point cp = this.PointToClient(sp);
                CvColor c = pictureBoxIpl1.ImageIpl[cp.Y - pictureBoxIpl1.Location.Y, cp.X - pictureBoxIpl1.Location.X];
                x.Text = "" + (cp.X - pictureBoxIpl1.Location.X);
                y.Text = "" + (cp.Y - pictureBoxIpl1.Location.Y);
                label1.Text = "r" + c.R + "g" + c.G + "b" + c.B;

            }
        }

        private void TextChanged_x(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                double isnumber_x, isnumber_y;
                if (double.TryParse(x.Text, out isnumber_x) && double.TryParse(y.Text, out isnumber_y))
                    if ((isnumber_x >= 0 && isnumber_x <= pictureBoxIpl1.ImageIpl.Width) && (isnumber_y >= 0 && isnumber_y <= pictureBoxIpl1.ImageIpl.Height))
                    {
                        CvColor c = pictureBoxIpl1.ImageIpl[(int)isnumber_y, (int)isnumber_x];
                        label1.Text = "r" + c.R + "g" + c.G + "b" + c.B;
                        //クライアント座標を画面座標に変換する
                        System.Drawing.Point mp = this.PointToScreen(new System.Drawing.Point((int)isnumber_x + pictureBoxIpl1.Location.X, (int)isnumber_y + pictureBoxIpl1.Location.Y));
                        //マウスポインタの位置を設定する
                        System.Windows.Forms.Cursor.Position = mp;
                    }
            }
        }

        private void TextChanged_y(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                double isnumber_x, isnumber_y;
                if (double.TryParse(x.Text, out isnumber_x) && double.TryParse(y.Text, out isnumber_y))
                    if ((isnumber_x >= 0 && isnumber_x <= pictureBoxIpl1.ImageIpl.Width) && (isnumber_y >= 0 && isnumber_y <= pictureBoxIpl1.ImageIpl.Height))
                    {
                        CvColor c = pictureBoxIpl1.ImageIpl[(int)isnumber_y, (int)isnumber_x];
                        label1.Text = "r" + c.R + "g" + c.G + "b" + c.B;
                        //クライアント座標を画面座標に変換する
                        System.Drawing.Point mp = this.PointToScreen(new System.Drawing.Point((int)isnumber_x + pictureBoxIpl1.Location.X, (int)isnumber_y + pictureBoxIpl1.Location.Y));
                        //マウスポインタの位置を設定する
                        System.Windows.Forms.Cursor.Position = mp;
                    }
            }
        }
    }
}
