using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmNearK : frmBase
    {
        public frmNearK() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            byte th = (byte)nudThreshold.Value;
            byte k = (byte)nudK.Value;
            InRaManHinh(NearK(_imgSoucre, th, k));
        }

        private Bitmap NearK(Bitmap img, int th, int k)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            for (int x = 0; x < imgResult.Width - 2; x++)
                for (int y = 0; y < imgResult.Height - 2; y++)
                {
                    var list_grey = new List<int>();
                    var list_khoangcach = new List<int>();
                    list_grey.Clear();
                    list_khoangcach.Clear();

                    int center_grey = imgResult.GetPixel(x + 1, y + 1).R;

                    for (int i = x; i < x + 3; i++)
                        for (int j = y; j < y + 3; j++)
                        {
                            int grey = imgResult.GetPixel(i, j).R;
                            list_grey.Add(grey);
                        }

                    list_khoangcach.AddRange(list_grey.Select(item => Math.Abs(item - center_grey)));

                    int sum = 0;
                    for (int n = 0; n < k; n++)
                    {
                        int idx = list_khoangcach.IndexOf(list_khoangcach.Min());
                        sum += list_grey[idx];
                        list_grey.RemoveAt(idx);
                        list_khoangcach.RemoveAt(idx);
                    }
                    sum /= k;

                    if (Math.Abs(center_grey - sum) > th)
                    {
                        center_grey = sum;
                        imgResult.SetPixel(x + 1, y + 1, Color.FromArgb(center_grey, center_grey, center_grey));
                    }
                }
            return imgResult;
        }
    }
}
