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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmiChuyenanhxam_Click(object sender, EventArgs e)
        {
            frmChuyenAnhXam frm = new frmChuyenAnhXam();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiTanggiamdosang_Click(object sender, EventArgs e)
        {
            frmTangGiamDoSang frm = new frmTangGiamDoSang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiTachnguong_Click(object sender, EventArgs e)
        {
            frmTachNguong frm = new frmTachNguong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiBocum_Click(object sender, EventArgs e)
        {
            frmBoCum frm = new frmBoCum();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiTangdotuongphan_Click(object sender, EventArgs e)
        {
            frmTangDoTuongPhan frm = new frmTangDoTuongPhan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiAnhamban_Click(object sender, EventArgs e)
        {
            frmAnhAmBan frm = new frmAnhAmBan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiVeHistogram_Click(object sender, EventArgs e)
        {
            frmHistogram frm = new frmHistogram();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiLoctrungvi_Click(object sender, EventArgs e)
        {
            frmLocTrungVi frm = new frmLocTrungVi();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiLoctrungbinh_Click(object sender, EventArgs e)
        {
            frmLocTrungBinh frm = new frmLocTrungBinh();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiLoctheokgiatri_Click(object sender, EventArgs e)
        {
            frmNearK frm = new frmNearK();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiSobel_Click(object sender, EventArgs e)
        {
            frmSobel frm = new frmSobel();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmiLaplace_Click(object sender, EventArgs e)
        {
            frmLaplace frm = new frmLaplace();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
