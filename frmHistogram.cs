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
    public partial class frmHistogram : frmBase
    {
        public frmHistogram() : base()
        {
            InitializeComponent();
        }

        public override void btnOpen_Click(object sender, EventArgs e)
        {
            base.btnOpen_Click(sender, e);            
            InRaManHinh(Histogram(_imgSoucre));
        }

        public Bitmap Histogram(Bitmap img)
        {
            Bitmap imgGrey = ChuyenAnhXam(img);
            int[] h = new int[256];
            for (int x = 0; x < imgGrey.Width; x++)
                for (int y = 0; y < imgGrey.Height; y++)
                {
                    byte grey = imgGrey.GetPixel(x, y).R;
                    h[grey]++;
                }

            //Set lại miền giá trị cho mảng nằm trong miền giá trị từ (0-255)
            int _max = h.Max();
            for (int i = 0; i < h.Length; i++)
                h[i] = (h[i] * 255 / _max);
            
            //Vẽ biểu đồ
            Bitmap imgHistogram = new Bitmap(256, 256);
            for (int x = 0; x < 256; x++)
                for (int y = 255; 255 - y <= h[x]; y--)
                    imgHistogram.SetPixel(x, y, Color.Black);

            return imgHistogram;
        }
    }
}
