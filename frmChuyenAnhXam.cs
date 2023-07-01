using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmChuyenAnhXam : frmBase
    {
        public frmChuyenAnhXam() : base()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_imgSoucre == null)
                return;

            InRaManHinh(ChuyenAnhXam(_imgSoucre));
        }
    }
}
