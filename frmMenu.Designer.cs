namespace XuLyAnh
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiChuyenanhxam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVeHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKhongphuthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTanggiamdosang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTachnguong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBocum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTangdotuongphan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnhamban = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhuthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoctrungvi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoctrungbinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoctheokgiatri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLaplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(274, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(237, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên sinh viên: Phạm Hồng Cảnh";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChuyenanhxam,
            this.tsmiVeHistogram,
            this.tsmiKhongphuthuoc,
            this.tsmiPhuthuoc,
            this.tsmiBien});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmiChuyenanhxam
            // 
            this.tsmiChuyenanhxam.Name = "tsmiChuyenanhxam";
            this.tsmiChuyenanhxam.Size = new System.Drawing.Size(109, 20);
            this.tsmiChuyenanhxam.Text = "Chuyển ảnh xám";
            this.tsmiChuyenanhxam.Click += new System.EventHandler(this.tsmiChuyenanhxam_Click);
            // 
            // tsmiVeHistogram
            // 
            this.tsmiVeHistogram.Name = "tsmiVeHistogram";
            this.tsmiVeHistogram.Size = new System.Drawing.Size(91, 20);
            this.tsmiVeHistogram.Text = "Vẽ Histogram";
            this.tsmiVeHistogram.Click += new System.EventHandler(this.tsmiVeHistogram_Click);
            // 
            // tsmiKhongphuthuoc
            // 
            this.tsmiKhongphuthuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTanggiamdosang,
            this.tsmiTachnguong,
            this.tsmiBocum,
            this.tsmiTangdotuongphan,
            this.tsmiAnhamban});
            this.tsmiKhongphuthuoc.Name = "tsmiKhongphuthuoc";
            this.tsmiKhongphuthuoc.Size = new System.Drawing.Size(221, 20);
            this.tsmiKhongphuthuoc.Text = "Kỹ thuật không phụ thuộc không gian";
            // 
            // tsmiTanggiamdosang
            // 
            this.tsmiTanggiamdosang.Name = "tsmiTanggiamdosang";
            this.tsmiTanggiamdosang.Size = new System.Drawing.Size(181, 22);
            this.tsmiTanggiamdosang.Text = "Tăng giảm độ sáng";
            this.tsmiTanggiamdosang.Click += new System.EventHandler(this.tsmiTanggiamdosang_Click);
            // 
            // tsmiTachnguong
            // 
            this.tsmiTachnguong.Name = "tsmiTachnguong";
            this.tsmiTachnguong.Size = new System.Drawing.Size(181, 22);
            this.tsmiTachnguong.Text = "Tách ngưỡng";
            this.tsmiTachnguong.Click += new System.EventHandler(this.tsmiTachnguong_Click);
            // 
            // tsmiBocum
            // 
            this.tsmiBocum.Name = "tsmiBocum";
            this.tsmiBocum.Size = new System.Drawing.Size(181, 22);
            this.tsmiBocum.Text = "Bó cụm";
            this.tsmiBocum.Click += new System.EventHandler(this.tsmiBocum_Click);
            // 
            // tsmiTangdotuongphan
            // 
            this.tsmiTangdotuongphan.Name = "tsmiTangdotuongphan";
            this.tsmiTangdotuongphan.Size = new System.Drawing.Size(181, 22);
            this.tsmiTangdotuongphan.Text = "Tăng độ tương phản";
            this.tsmiTangdotuongphan.Click += new System.EventHandler(this.tsmiTangdotuongphan_Click);
            // 
            // tsmiAnhamban
            // 
            this.tsmiAnhamban.Name = "tsmiAnhamban";
            this.tsmiAnhamban.Size = new System.Drawing.Size(181, 22);
            this.tsmiAnhamban.Text = "Ảnh âm bản";
            this.tsmiAnhamban.Click += new System.EventHandler(this.tsmiAnhamban_Click);
            // 
            // tsmiPhuthuoc
            // 
            this.tsmiPhuthuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoctrungvi,
            this.tsmiLoctrungbinh,
            this.tsmiLoctheokgiatri});
            this.tsmiPhuthuoc.Name = "tsmiPhuthuoc";
            this.tsmiPhuthuoc.Size = new System.Drawing.Size(184, 20);
            this.tsmiPhuthuoc.Text = "Kỹ thuật phụ thuộc không gian";
            // 
            // tsmiLoctrungvi
            // 
            this.tsmiLoctrungvi.Name = "tsmiLoctrungvi";
            this.tsmiLoctrungvi.Size = new System.Drawing.Size(212, 22);
            this.tsmiLoctrungvi.Text = "Lọc trung vị";
            this.tsmiLoctrungvi.Click += new System.EventHandler(this.tsmiLoctrungvi_Click);
            // 
            // tsmiLoctrungbinh
            // 
            this.tsmiLoctrungbinh.Name = "tsmiLoctrungbinh";
            this.tsmiLoctrungbinh.Size = new System.Drawing.Size(212, 22);
            this.tsmiLoctrungbinh.Text = "Lọc trung bình";
            this.tsmiLoctrungbinh.Click += new System.EventHandler(this.tsmiLoctrungbinh_Click);
            // 
            // tsmiLoctheokgiatri
            // 
            this.tsmiLoctheokgiatri.Name = "tsmiLoctheokgiatri";
            this.tsmiLoctheokgiatri.Size = new System.Drawing.Size(212, 22);
            this.tsmiLoctheokgiatri.Text = "Lọc theo k giá trị gần nhất";
            this.tsmiLoctheokgiatri.Click += new System.EventHandler(this.tsmiLoctheokgiatri_Click);
            // 
            // tsmiBien
            // 
            this.tsmiBien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSobel,
            this.tsmiLaplace});
            this.tsmiBien.Name = "tsmiBien";
            this.tsmiBien.Size = new System.Drawing.Size(142, 20);
            this.tsmiBien.Text = "Kỹ thuật phát hiện biên";
            // 
            // tsmiSobel
            // 
            this.tsmiSobel.Name = "tsmiSobel";
            this.tsmiSobel.Size = new System.Drawing.Size(180, 22);
            this.tsmiSobel.Text = "Sobel";
            this.tsmiSobel.Click += new System.EventHandler(this.tsmiSobel_Click);
            // 
            // tsmiLaplace
            // 
            this.tsmiLaplace.Name = "tsmiLaplace";
            this.tsmiLaplace.Size = new System.Drawing.Size(180, 22);
            this.tsmiLaplace.Text = "Laplace";
            this.tsmiLaplace.Click += new System.EventHandler(this.tsmiLaplace_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 61);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 100);
            this.MinimumSize = new System.Drawing.Size(800, 100);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiChuyenanhxam;
        private System.Windows.Forms.ToolStripMenuItem tsmiKhongphuthuoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiTanggiamdosang;
        private System.Windows.Forms.ToolStripMenuItem tsmiTachnguong;
        private System.Windows.Forms.ToolStripMenuItem tsmiBocum;
        private System.Windows.Forms.ToolStripMenuItem tsmiTangdotuongphan;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhuthuoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnhamban;
        private System.Windows.Forms.ToolStripMenuItem tsmiVeHistogram;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoctrungvi;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoctrungbinh;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoctheokgiatri;
        private System.Windows.Forms.ToolStripMenuItem tsmiBien;
        private System.Windows.Forms.ToolStripMenuItem tsmiSobel;
        private System.Windows.Forms.ToolStripMenuItem tsmiLaplace;
    }
}