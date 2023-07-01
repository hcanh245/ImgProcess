using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmSobel : frmBase
    {
        public frmSobel() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;
            InRaManHinh(Sobel(_imgSoucre));
        }

        private Bitmap Sobel(Bitmap img)
        {
            int[,] Hx =
            {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };
            int[,] Hy =
            {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };
            Bitmap imgResult = ChuyenAnhXam(img);
            for (int x = 0; x < imgResult.Width - 2; x++)
                for (int y = 0; y < imgResult.Height - 2; y++)
                {
                    int dx = 0, dy = 0;
                    for (int n = 0; n < 3; n++)
                        for (int m = 0; m < 3; m++)
                        {
                            int grey = img.GetPixel(x + n, y + m).R;
                            dx += grey * Hx[n, m];
                            dy += grey * Hy[n, m];
                        }

                    int derivata = Math.Abs(dx) + Math.Abs(dy);
                    if (derivata < 0) derivata = 0;
                    if (derivata > 255) derivata = 255;
                    imgResult.SetPixel(x, y, Color.FromArgb(derivata, derivata, derivata));
                }
            return imgResult;
        }
    }
}
