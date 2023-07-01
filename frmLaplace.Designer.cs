namespace XuLyAnh
{
    partial class frmLaplace
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
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnAction);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAction.Location = new System.Drawing.Point(409, 38);
            this.btnAction.MaximumSize = new System.Drawing.Size(100, 30);
            this.btnAction.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 30);
            this.btnAction.TabIndex = 28;
            this.btnAction.Text = "Thực thi";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // frmLaplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Name = "frmLaplace";
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
    }
}
