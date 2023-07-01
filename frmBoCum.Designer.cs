namespace XuLyAnh
{
    partial class frmBoCum
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
            this.nudBunch_Size = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBunch_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAction.Location = new System.Drawing.Point(455, 410);
            this.btnAction.MaximumSize = new System.Drawing.Size(100, 30);
            this.btnAction.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 30);
            this.btnAction.TabIndex = 18;
            this.btnAction.Text = "Bó cụm";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // nudBunch_Size
            // 
            this.nudBunch_Size.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudBunch_Size.Location = new System.Drawing.Point(389, 412);
            this.nudBunch_Size.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBunch_Size.Name = "nudBunch_Size";
            this.nudBunch_Size.Size = new System.Drawing.Size(60, 26);
            this.nudBunch_Size.TabIndex = 17;
            this.nudBunch_Size.Tag = "";
            this.nudBunch_Size.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // frmBoCum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.nudBunch_Size);
            this.Name = "frmBoCum";
            this.Text = "frmBoCum";
            this.Controls.SetChildIndex(this.nudBunch_Size, 0);
            this.Controls.SetChildIndex(this.btnAction, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudBunch_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.NumericUpDown nudBunch_Size;
    }
}