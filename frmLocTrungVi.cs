using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmLocTrungVi : XuLyAnh.frmBase
    {
        public frmLocTrungVi()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            byte _th = (byte)nudThreshold.Value;
            InRaManHinh(LocTrungVi(_imgSoucre, _th));
        }

        private Bitmap LocTrungVi(Bitmap img, int th)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            int k = 0;
            int[] a = new int[9];
            for (int x = 0; x < imgResult.Width - 2; x++)
                for (int y = 0; y < imgResult.Height - 2; y++)
                {
                    int center = imgResult.GetPixel(x + 1, y + 1).R;
                    for (int i = x; i < x + 3; i++)
                        for (int j = y; j < y + 3; j++)
                        {
                            int grey = imgResult.GetPixel(i, j).R;
                            a[k] = grey;
                            k++;
                        }
                    k = 0;
                    Array.Sort(a);
                    if (Math.Abs(center - a[4]) > th)
                    {
                        center = a[4];
                        imgResult.SetPixel(x + 1, y + 1, Color.FromArgb(center, center, center));
                    }
                }
            return imgResult;
        }
    }
}
