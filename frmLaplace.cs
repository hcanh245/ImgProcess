using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmLaplace : frmBase
    {
        public frmLaplace() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            InRaManHinh(Laplace(_imgSoucre));
        }

        private Bitmap Laplace(Bitmap img)
        {
            int[,] H =
            {
                { 0, 1, 0 },
                { 1, -4, 1 },
                { 0, 1, 0 }
            };

            Bitmap imgResult = ChuyenAnhXam(img);

            for (int x = 0; x < imgResult.Width - 2; x++)
                for (int y = 0; y < imgResult.Height - 2; y++)
                {
                    int d = 0;
                    for (int n = 0; n < 3; n++)
                        for (int m = 0; m < 3; m++)
                        {
                            int grey = img.GetPixel(x + n, y + m).R;
                            d += grey * H[n, m];
                        }
                    if (d < 0) d = 0;
                    if (d > 255) d = 255;
                    imgResult.SetPixel(x, y, Color.FromArgb(d, d, d));
                }
            return imgResult;
        }
    }
}
