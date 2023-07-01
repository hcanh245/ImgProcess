namespace XuLyAnh
{
    partial class frmTangGiamDoSang
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
            this.trbC = new System.Windows.Forms.TrackBar();
            this.lblC = new System.Windows.Forms.Label();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.lblC);
            this.pnlAction.Controls.Add(this.trbC);
            // 
            // trbC
            // 
            this.trbC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trbC.Location = new System.Drawing.Point(204, 42);
            this.trbC.Maximum = 255;
            this.trbC.Minimum = -255;
            this.trbC.Name = "trbC";
            this.trbC.Size = new System.Drawing.Size(511, 45);
            this.trbC.TabIndex = 15;
            this.trbC.Scroll += new System.EventHandler(this.trb_Scroll);
            // 
            // lblC
            // 
            this.lblC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(451, 20);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 19);
            this.lblC.TabIndex = 17;
            this.lblC.Text = "0";
            // 
            // frmTangGiamDoSang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTangGiamDoSang";
            this.Text = "Tăng giảm độ sáng";
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trbC;
        private System.Windows.Forms.Label lblC;
    }
}