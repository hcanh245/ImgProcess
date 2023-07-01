namespace XuLyAnh
{
    partial class frmTachNguong
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
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.lblThreshold);
            this.pnlAction.Controls.Add(this.nudThreshold);
            this.pnlAction.Controls.Add(this.btnAction);
            this.pnlAction.Controls.Add(this.btnSearch);
            // 
            // nudThreshold
            // 
            this.nudThreshold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudThreshold.Location = new System.Drawing.Point(415, 23);
            this.nudThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(60, 26);
            this.nudThreshold.TabIndex = 15;
            this.nudThreshold.Tag = "";
            this.nudThreshold.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAction.Location = new System.Drawing.Point(481, 21);
            this.btnAction.MaximumSize = new System.Drawing.Size(100, 30);
            this.btnAction.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 30);
            this.btnAction.TabIndex = 16;
            this.btnAction.Text = "Tách ngưỡng";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(395, 55);
            this.btnSearch.MaximumSize = new System.Drawing.Size(100, 30);
            this.btnSearch.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Tìm ngưỡng";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(337, 27);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(72, 19);
            this.lblThreshold.TabIndex = 26;
            this.lblThreshold.Text = "Threshold:";
            // 
            // frmTachNguong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Name = "frmTachNguong";
            this.Text = "Tách ngưỡng";
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblThreshold;
    }
}