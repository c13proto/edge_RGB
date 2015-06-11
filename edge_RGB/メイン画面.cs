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
    public partial class メイン画面 : Form
    {
        public static IplImage      入力画像;
        public static IplImage[]    入力画像_RGB=new IplImage[3];
        public static IplImage      出力画像;

        public メイン画面()
        {
            InitializeComponent();
        }

        private void OnClick開く(object sender, EventArgs e)
        {
            画像の初期化();

            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = false,  // 複数選択の可否
                Filter =  // フィルタ
                "画像ファイル|*.bmp;*.gif;*.jpg;*.png|全てのファイル|*.*",
            };
            //ダイアログを表示
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                //OKボタンがクリックされたとき
                //選択されたファイル名をすべて表示する
                入力画像 = new IplImage(dialog.FileName, LoadMode.Color);
                // ファイル名をタイトルバーに設定
                this.Text = dialog.FileName;
                入力画像_RGB作成();
                R.Instance.Show();
                G.Instance.Show();
                B.Instance.Show();

                画像表示(入力画像);
            }
        }
        private void 画像表示(IplImage src)
        {
            pictureBoxIpl1.Width = src.Width;
            pictureBoxIpl1.Height = src.Height;
            pictureBoxIpl1.ImageIpl = src;

        }
        private void 画像の初期化()
        {
            if (入力画像 != null) 入力画像.Dispose();
            for (int i = 0; i < 3; i++)
                if (入力画像_RGB[i] != null) 入力画像_RGB[i].Dispose();
        }
        private void 入力画像_RGB作成()
        {
            for (int i = 0; i < 3; i++)
            {
                入力画像_RGB[i] = Cv.CreateImage(入力画像.Size, BitDepth.U8, 1);
                入力画像_RGB[i].Zero();
            }
            for (int x = 0; x < 入力画像.Width; x++)
                for (int y = 0; y < 入力画像.Height; y++)
                {
                    CvColor c = 入力画像[y, x];
                    入力画像_RGB[0].Set2D(y, x, c.R);
                    入力画像_RGB[1].Set2D(y, x, c.G);
                    入力画像_RGB[2].Set2D(y, x, c.B);
                }

        }

        private void OnClick合成(object sender, EventArgs e)
        {

        }

        private void OnClick_PictureboxIpl1(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                System.Drawing.Point cp = this.PointToClient(sp);
                CvColor c = pictureBoxIpl1.ImageIpl[cp.Y - pictureBoxIpl1.Location.Y, cp.X - pictureBoxIpl1.Location.X];
                x.Text = ""+(cp.X - pictureBoxIpl1.Location.X);
                y.Text = ""+(cp.Y - pictureBoxIpl1.Location.Y);
                label1.Text = "r"+c.R+"g"+c.G+"b"+c.B;

            }
        }

        private void Text_Changed_x(object sender, EventArgs e)
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
