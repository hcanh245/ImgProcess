﻿namespace XuLyAnh
{
    partial class frmLocTrungBinh
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
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.lblThreshold);
            this.pnlAction.Controls.Add(this.nudThreshold);
            this.pnlAction.Controls.Add(this.btnAction);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(357, 44);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(72, 19);
            this.lblThreshold.TabIndex = 32;
            this.lblThreshold.Text = "Threshold:";
            // 
            // nudThreshold
            // 
            this.nudThreshold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudThreshold.Location = new System.Drawing.Point(435, 40);
            this.nudThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(60, 26);
            this.nudThreshold.TabIndex = 31;
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
            this.btnAction.Location = new System.Drawing.Point(501, 40);
            this.btnAction.MaximumSize = new System.Drawing.Size(60, 26);
            this.btnAction.MinimumSize = new System.Drawing.Size(60, 26);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(60, 26);
            this.btnAction.TabIndex = 30;
            this.btnAction.Text = "Lọc";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // frmLocTrungBinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Name = "frmLocTrungBinh";
            this.Text = "frmLocTrungBinh";
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.Button btnAction;
    }
}