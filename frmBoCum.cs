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
    public partial class frmBoCum : frmBase
    {
        public frmBoCum() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;

            int _bunch_size = (int)nudBunch_Size.Value;
            
            InRaManHinh(BunchSize(_imgSoucre, _bunch_size));
        }

        private Bitmap BunchSize(Bitmap img, int bunch_size)
        {
            Bitmap imgResult = ChuyenAnhXam(img);
            for (int x = 0; x < img.Width; x++)
                for (int y = 0; y < img.Height; y++)
                {
                    int grey = img.GetPixel(x, y).R;
                    int new_grey = grey / bunch_size * bunch_size;
                    imgResult.SetPixel(x, y, Color.FromArgb(new_grey, new_grey, new_grey));
                }
            return imgResult;
        }
    }
}
