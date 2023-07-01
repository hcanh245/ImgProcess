namespace XuLyAnh
{
    partial class frmH
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
            this.ptbH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbH)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbH
            // 
            this.ptbH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptbH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbH.Location = new System.Drawing.Point(14, 2);
            this.ptbH.MaximumSize = new System.Drawing.Size(256, 256);
            this.ptbH.MinimumSize = new System.Drawing.Size(256, 256);
            this.ptbH.Name = "ptbH";
            this.ptbH.Size = new System.Drawing.Size(256, 256);
            this.ptbH.TabIndex = 2;
            this.ptbH.TabStop = false;
            // 
            // frmH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ptbH);
            this.Name = "frmH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.frmH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbH;
    }
}