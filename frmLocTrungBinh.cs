using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmLocTrungBinh : frmBase
    {
        public frmLocTrungBinh() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;

            byte _th = (byte)nudThreshold.Value;

            InRaManHinh(LocTrungBinh(_imgSoucre, _th));
        }

        private Bitmap LocTrungBinh(Bitmap img, int th)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            for (int x = 0; x < imgResult.Width - 2; x++)
                for (int y = 0; y < imgResult.Height - 2; y++)
                {
                    int center = imgResult.GetPixel(x + 1, y + 1).R;
                    int sum = 0;
                    for (int i = x; i < x + 3; i++)
                        for (int j = y; j < y + 3; j++)
                        {
                            int grey = imgResult.GetPixel(i, j).R;
                            sum += grey;
                        }
                    int avg = sum / 9;
                    if (Math.Abs(center - avg) > th)
                    {
                        center = avg;
                        imgResult.SetPixel(x + 1, y + 1, Color.FromArgb(center, center, center));
                    }
                }
            return imgResult;
        }
    }
}
