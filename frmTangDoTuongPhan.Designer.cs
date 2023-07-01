namespace XuLyAnh
{
    partial class frmTangDoTuongPhan
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
            this.btnAction = new System.Windows.Forms.Button();
            this.btnH_Source = new System.Windows.Forms.Button();
            this.btnH_Result = new System.Windows.Forms.Button();
            this.pnlAction.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnAction);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.btnH_Result);
            this.pnlBase.Controls.Add(this.btnH_Source);
            this.pnlBase.Controls.SetChildIndex(this.btnH_Source, 0);
            this.pnlBase.Controls.SetChildIndex(this.btnH_Result, 0);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAction.Location = new System.Drawing.Point(409, 33);
            this.btnAction.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnAction.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 40);
            this.btnAction.TabIndex = 26;
            this.btnAction.Text = "Chuyển";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnH_Source
            // 
            this.btnH_Source.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnH_Source.Location = new System.Drawing.Point(211, 307);
            this.btnH_Source.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnH_Source.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnH_Source.Name = "btnH_Source";
            this.btnH_Source.Size = new System.Drawing.Size(100, 40);
            this.btnH_Source.TabIndex = 27;
            this.btnH_Source.Text = "Histogram";
            this.btnH_Source.UseVisualStyleBackColor = true;
            this.btnH_Source.Click += new System.EventHandler(this.btnH_Source_Click);
            // 
            // btnH_Result
            // 
            this.btnH_Result.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnH_Result.Location = new System.Drawing.Point(714, 307);
            this.btnH_Result.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnH_Result.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnH_Result.Name = "btnH_Result";
            this.btnH_Result.Size = new System.Drawing.Size(100, 40);
            this.btnH_Result.TabIndex = 28;
            this.btnH_Result.Text = "Histogram";
            this.btnH_Result.UseVisualStyleBackColor = true;
            this.btnH_Result.Click += new System.EventHandler(this.btnH_Result_Click);
            // 
            // frmTangDoTuongPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Name = "frmTangDoTuongPhan";
            this.Text = "frmTangDoTuongPhan";
            this.pnlAction.ResumeLayout(false);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnH_Result;
        private System.Windows.Forms.Button btnH_Source;
    }
}