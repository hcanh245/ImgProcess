using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmTachNguong : frmBase
    {
        public frmTachNguong() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            byte th = (byte)nudThreshold.Value;
            InRaManHinh(Threshold(_imgSoucre, th));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            nudThreshold.Value = FindThreshold(_imgSoucre);
        }

        private Bitmap Threshold(Bitmap img, int th)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            for (int x = 0; x < imgResult.Width; x++)
                for (int y = 0; y < imgResult.Height; y++)
                {
                    int grey = imgResult.GetPixel(x, y).R;
                    if (grey >= th)
                        imgResult.SetPixel(x, y, Color.White);
                    else
                        imgResult.SetPixel(x, y, Color.Black);
                }
            return imgResult;
        }

        private int FindThreshold(Bitmap img)
        {
            Bitmap img_grey = base.ChuyenAnhXam(img);
            byte th0 = 128;
            byte th1 = 0;
            while (true)
            {
                int sum0 = 0, count0 = 0, sum1 = 0, count1 = 0;
                for (int x = 0; x < img_grey.Width; x++)
                    for (int y = 0; y < img_grey.Height; y++)
                    {
                        int grey = img_grey.GetPixel(x, y).R;
                        if (grey > th0)
                        {
                            count1++;
                            sum1 += grey;
                        }
                        else
                        {
                            count0++;
                            sum0 += grey;
                        }
                    }

                if (count0 != 0 && count1 != 0)
                    th1 = (byte)Math.Round((sum1 / count1 + sum0 / count0) / 2.0);
                
                if (Math.Abs(th0 - th1) <= 2)
                    break;
                
                th0 = th1;
            }
            return th0;
        }
    }
}
