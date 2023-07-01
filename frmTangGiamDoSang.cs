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
    public partial class frmTangGiamDoSang : frmBase
    {
        public frmTangGiamDoSang() : base()
        {
            InitializeComponent();
        }

        private void trb_Scroll(object sender, EventArgs e)
        {
            Bitmap _img = ChuyenAnhXam(_imgSoucre);
            lblC.Text = trbC.Value.ToString();
            if (_img == null)
                return;
            int c = trbC.Value;
            Color c2;
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    Color c1 = _img.GetPixel(x, y);
                    int tmp = c1.R + c;
                    if (tmp > 255)
                        c2 = Color.White;
                    else if (tmp < 0)
                        c2 = Color.Black;
                    else
                        c2 = Color.FromArgb(tmp, tmp, tmp);
                    _img.SetPixel(x, y, c2);
                }
            InRaManHinh(_img);
        }
    }
}
