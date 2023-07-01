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
    public partial class frmAnhAmBan : frmBase
    {
        public frmAnhAmBan() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;

            InRaManHinh(NegativeImage(_imgSoucre));
        }

        private Bitmap NegativeImage(Bitmap img)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            for (int x = 0; x < imgResult.Width; x++)
                for (int y = 0; y < imgResult.Height; y++)
                {
                    byte grey = imgResult.GetPixel(x, y).R;
                    int amban = 255 - grey;
                    imgResult.SetPixel(x, y, Color.FromArgb(amban, amban, amban));
                }
            return imgResult;
        }
    }
}
