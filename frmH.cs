using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmH : Form
    {
        private Bitmap _img;

        public frmH()
        {
            InitializeComponent();
        }

        public frmH(Bitmap Img) : this()
        {
            _img = Img;
        }

        private void frmH_Load(object sender, EventArgs e)
        {
            ptbH.Image = _img;
        }
    }
}
