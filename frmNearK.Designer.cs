namespace XuLyAnh
{
    partial class frmNearK
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
            this.lblThreshold = new System.Windows.Forms.Label();
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblK = new System.Windows.Forms.Label();
            this.nudK = new System.Windows.Forms.NumericUpDown();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.lblK);
            this.pnlAction.Controls.Add(this.nudK);
            this.pnlAction.Controls.Add(this.lblThreshold);
            this.pnlAction.Controls.Add(this.nudThreshold);
            this.pnlAction.Controls.Add(this.btnAction);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(357, 28);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(72, 19);
            this.lblThreshold.TabIndex = 35;
            this.lblThreshold.Text = "Threshold:";
            // 
            // nudThreshold
            // 
            this.nudThreshold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudThreshold.Location = new System.Drawing.Point(435, 24);
            this.nudThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(60, 26);
            this.nudThreshold.TabIndex = 34;
            this.nudThreshold.Tag = "";
            this.nudThreshold.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAction.Location = new System.Drawing.Point(501, 24);
            this.btnAction.MaximumSize = new System.Drawing.Size(60, 58);
            this.btnAction.MinimumSize = new System.Drawing.Size(60, 58);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(60, 58);
            this.btnAction.TabIndex = 33;
            this.btnAction.Text = "Lọc";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(357, 60);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(24, 19);
            this.lblK.TabIndex = 37;
            this.lblK.Text = "K:";
            // 
            // nudK
            // 
            this.nudK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudK.Location = new System.Drawing.Point(435, 56);
            this.nudK.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudK.Name = "nudK";
            this.nudK.Size = new System.Drawing.Size(60, 26);
            this.nudK.TabIndex = 36;
            this.nudK.Tag = "";
            this.nudK.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmLocTheoKGiaTriGanNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Name = "frmLocTheoKGiaTriGanNhat";
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.NumericUpDown nudK;
    }
}
