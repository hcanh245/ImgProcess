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
    public partial class frmBase : Form
    {
        public Bitmap _imgSoucre = null;
        public Bitmap _imgResult = null;

        public frmBase()
        {
            InitializeComponent();
        }

        public virtual void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && openFileDialog.FileName != "")
            {
                txtPath.Text = openFileDialog.FileName;
                _imgSoucre = new Bitmap(openFileDialog.FileName);
                ptbSoucre.Image = _imgSoucre;

                _imgResult = new Bitmap(_imgSoucre);
            }
        }

        public void InRaManHinh(Bitmap img)
        {
            _imgResult = img;
            ptbResult.Image = _imgResult;
        }

        public Bitmap ChuyenAnhXam(Bitmap img)
        {
            if (img == null)
                return null;
            Bitmap imgGrey = new Bitmap(img);
            for (int x = 0; x < img.Width; x++)
                for (int y = 0; y < img.Height; y++)
                {
                    Color c1 = img.GetPixel(x, y);
                    int tmp = (c1.R + c1.G + c1.B) / 3;
                    Color c2 = Color.FromArgb(tmp, tmp, tmp);
                    imgGrey.SetPixel(x, y, c2);
                }
            return imgGrey;
        }   

        public void ptbSoucre_MouseMove(object sender, MouseEventArgs e)
        {
            txtX_source.Text = e.X.ToString();
            txtY_source.Text = e.Y.ToString();
            if (_imgSoucre == null)
                return;
            if (e.X < _imgSoucre.Width && e.Y < _imgSoucre.Height)
            {
                Color c = _imgSoucre.GetPixel(e.X, e.Y);
                txtR_source.Text = c.R.ToString();
                txtG_source.Text = c.G.ToString();
                txtB_source.Text = c.B.ToString();
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK && saveFileDialog.FileName != "" && _imgResult != null)
            {
                _imgResult.Save(saveFileDialog.FileName);
            }
        }

        private void ptbResult_MouseMove(object sender, MouseEventArgs e)
        {
            txtX_result.Text = e.X.ToString();
            txtY_result.Text = e.Y.ToString();
            if (_imgResult == null)
                return;
            if (e.X < _imgResult.Width && e.Y < _imgResult.Height)
            {
                Color c = _imgResult.GetPixel(e.X, e.Y);
                txtR_result.Text = c.R.ToString();
                txtG_result.Text = c.G.ToString();
                txtB_result.Text = c.B.ToString();
            }
        }
    }
}
