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
    public partial class frmTangDoTuongPhan : frmBase
    {
        public frmTangDoTuongPhan() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;            
            InRaManHinh(TangTuongPhan(_imgSoucre));
        }

        private Bitmap TangTuongPhan(Bitmap img)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            int min = imgResult.GetPixel(0, 0).R;
            int max = imgResult.GetPixel(0, 0).R;
            for (int x = 0; x < imgResult.Width; x++)
                for (int y = 0; y < imgResult.Height; y++)
                {
                    byte grey = imgResult.GetPixel(x, y).R;
                    if (grey > max)
                        max = grey;
                    if (grey < min)
                        min = grey;
                }
            
            for (int x = 0; x < imgResult.Width; x++)
                for (int y = 0; y < imgResult.Height; y++)
                {
                    byte grey = imgResult.GetPixel(x, y).R;
                    int new_grey = 255 * (grey - min) / (max - min);
                    imgResult.SetPixel(x, y, Color.FromArgb(new_grey, new_grey, new_grey));
                }
            return imgResult;
        }

        private void btnH_Source_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            var h = new frmHistogram();
            frmH frm = new frmH(h.Histogram(_imgSoucre));
            frm.Show();
        }

        private void btnH_Result_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            var h = new frmHistogram();
            frmH frm = new frmH(h.Histogram(TangTuongPhan(_imgSoucre)));
            frm.Show();
        }
    }
}
