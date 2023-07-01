namespace XuLyAnh
{
    partial class frmBase
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.ptbSoucre = new System.Windows.Forms.PictureBox();
            this.ptbResult = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtX_source = new System.Windows.Forms.TextBox();
            this.txtY_source = new System.Windows.Forms.TextBox();
            this.lblX_source = new System.Windows.Forms.Label();
            this.lblY_source = new System.Windows.Forms.Label();
            this.txtR_source = new System.Windows.Forms.TextBox();
            this.lblR_source = new System.Windows.Forms.Label();
            this.lblG_source = new System.Windows.Forms.Label();
            this.txtG_source = new System.Windows.Forms.TextBox();
            this.lblB_source = new System.Windows.Forms.Label();
            this.txtB_source = new System.Windows.Forms.TextBox();
            this.lblB_result = new System.Windows.Forms.Label();
            this.lblG_result = new System.Windows.Forms.Label();
            this.lblR_result = new System.Windows.Forms.Label();
            this.lblY_result = new System.Windows.Forms.Label();
            this.lblX_result = new System.Windows.Forms.Label();
            this.txtB_result = new System.Windows.Forms.TextBox();
            this.txtG_result = new System.Windows.Forms.TextBox();
            this.txtR_result = new System.Windows.Forms.TextBox();
            this.txtY_result = new System.Windows.Forms.TextBox();
            this.txtX_result = new System.Windows.Forms.TextBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.pnlBase = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSoucre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbResult)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(125, 307);
            this.btnOpen.MaximumSize = new System.Drawing.Size(80, 40);
            this.btnOpen.MinimumSize = new System.Drawing.Size(80, 40);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ptbSoucre
            // 
            this.ptbSoucre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptbSoucre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbSoucre.Location = new System.Drawing.Point(37, 45);
            this.ptbSoucre.MaximumSize = new System.Drawing.Size(256, 256);
            this.ptbSoucre.MinimumSize = new System.Drawing.Size(256, 256);
            this.ptbSoucre.Name = "ptbSoucre";
            this.ptbSoucre.Size = new System.Drawing.Size(256, 256);
            this.ptbSoucre.TabIndex = 1;
            this.ptbSoucre.TabStop = false;
            this.ptbSoucre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbSoucre_MouseMove);
            // 
            // ptbResult
            // 
            this.ptbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbResult.Location = new System.Drawing.Point(540, 45);
            this.ptbResult.MaximumSize = new System.Drawing.Size(256, 256);
            this.ptbResult.MinimumSize = new System.Drawing.Size(256, 256);
            this.ptbResult.Name = "ptbResult";
            this.ptbResult.Size = new System.Drawing.Size(256, 256);
            this.ptbResult.TabIndex = 3;
            this.ptbResult.TabStop = false;
            this.ptbResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbResult_MouseMove);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(628, 307);
            this.btnSave.MaximumSize = new System.Drawing.Size(80, 40);
            this.btnSave.MinimumSize = new System.Drawing.Size(80, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Bitmap files|*.bmp|JPEG files|*.jpg|PNG files|*.png";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(37, 13);
            this.txtPath.MaximumSize = new System.Drawing.Size(256, 26);
            this.txtPath.MinimumSize = new System.Drawing.Size(256, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(256, 22);
            this.txtPath.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Bitmap files|*.bmp|JPEG files|*.jpg|PNG files|*.png";
            // 
            // txtX_source
            // 
            this.txtX_source.Location = new System.Drawing.Point(329, 45);
            this.txtX_source.Name = "txtX_source";
            this.txtX_source.Size = new System.Drawing.Size(50, 26);
            this.txtX_source.TabIndex = 5;
            // 
            // txtY_source
            // 
            this.txtY_source.Location = new System.Drawing.Point(329, 80);
            this.txtY_source.Name = "txtY_source";
            this.txtY_source.Size = new System.Drawing.Size(50, 26);
            this.txtY_source.TabIndex = 6;
            // 
            // lblX_source
            // 
            this.lblX_source.AutoSize = true;
            this.lblX_source.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_source.Location = new System.Drawing.Point(299, 47);
            this.lblX_source.Name = "lblX_source";
            this.lblX_source.Size = new System.Drawing.Size(27, 21);
            this.lblX_source.TabIndex = 7;
            this.lblX_source.Text = "X:";
            // 
            // lblY_source
            // 
            this.lblY_source.AutoSize = true;
            this.lblY_source.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY_source.Location = new System.Drawing.Point(299, 82);
            this.lblY_source.Name = "lblY_source";
            this.lblY_source.Size = new System.Drawing.Size(25, 21);
            this.lblY_source.TabIndex = 8;
            this.lblY_source.Text = "Y:";
            // 
            // txtR_source
            // 
            this.txtR_source.Location = new System.Drawing.Point(329, 115);
            this.txtR_source.Name = "txtR_source";
            this.txtR_source.Size = new System.Drawing.Size(50, 26);
            this.txtR_source.TabIndex = 9;
            // 
            // lblR_source
            // 
            this.lblR_source.AutoSize = true;
            this.lblR_source.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_source.Location = new System.Drawing.Point(299, 117);
            this.lblR_source.Name = "lblR_source";
            this.lblR_source.Size = new System.Drawing.Size(27, 21);
            this.lblR_source.TabIndex = 10;
            this.lblR_source.Text = "R:";
            // 
            // lblG_source
            // 
            this.lblG_source.AutoSize = true;
            this.lblG_source.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG_source.Location = new System.Drawing.Point(299, 152);
            this.lblG_source.Name = "lblG_source";
            this.lblG_source.Size = new System.Drawing.Size(28, 21);
            this.lblG_source.TabIndex = 12;
            this.lblG_source.Text = "G:";
            // 
            // txtG_source
            // 
            this.txtG_source.Location = new System.Drawing.Point(329, 150);
            this.txtG_source.Name = "txtG_source";
            this.txtG_source.Size = new System.Drawing.Size(50, 26);
            this.txtG_source.TabIndex = 11;
            // 
            // lblB_source
            // 
            this.lblB_source.AutoSize = true;
            this.lblB_source.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_source.Location = new System.Drawing.Point(299, 187);
            this.lblB_source.Name = "lblB_source";
            this.lblB_source.Size = new System.Drawing.Size(26, 21);
            this.lblB_source.TabIndex = 14;
            this.lblB_source.Text = "B:";
            // 
            // txtB_source
            // 
            this.txtB_source.Location = new System.Drawing.Point(329, 185);
            this.txtB_source.Name = "txtB_source";
            this.txtB_source.Size = new System.Drawing.Size(50, 26);
            this.txtB_source.TabIndex = 13;
            // 
            // lblB_result
            // 
            this.lblB_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblB_result.AutoSize = true;
            this.lblB_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_result.Location = new System.Drawing.Point(802, 187);
            this.lblB_result.Name = "lblB_result";
            this.lblB_result.Size = new System.Drawing.Size(26, 21);
            this.lblB_result.TabIndex = 24;
            this.lblB_result.Text = "B:";
            // 
            // lblG_result
            // 
            this.lblG_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblG_result.AutoSize = true;
            this.lblG_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG_result.Location = new System.Drawing.Point(802, 152);
            this.lblG_result.Name = "lblG_result";
            this.lblG_result.Size = new System.Drawing.Size(28, 21);
            this.lblG_result.TabIndex = 22;
            this.lblG_result.Text = "G:";
            // 
            // lblR_result
            // 
            this.lblR_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblR_result.AutoSize = true;
            this.lblR_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_result.Location = new System.Drawing.Point(802, 117);
            this.lblR_result.Name = "lblR_result";
            this.lblR_result.Size = new System.Drawing.Size(27, 21);
            this.lblR_result.TabIndex = 20;
            this.lblR_result.Text = "R:";
            // 
            // lblY_result
            // 
            this.lblY_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY_result.AutoSize = true;
            this.lblY_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY_result.Location = new System.Drawing.Point(802, 82);
            this.lblY_result.Name = "lblY_result";
            this.lblY_result.Size = new System.Drawing.Size(25, 21);
            this.lblY_result.TabIndex = 18;
            this.lblY_result.Text = "Y:";
            // 
            // lblX_result
            // 
            this.lblX_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX_result.AutoSize = true;
            this.lblX_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_result.Location = new System.Drawing.Point(802, 47);
            this.lblX_result.Name = "lblX_result";
            this.lblX_result.Size = new System.Drawing.Size(27, 21);
            this.lblX_result.TabIndex = 17;
            this.lblX_result.Text = "X:";
            // 
            // txtB_result
            // 
            this.txtB_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtB_result.Location = new System.Drawing.Point(832, 185);
            this.txtB_result.Name = "txtB_result";
            this.txtB_result.Size = new System.Drawing.Size(50, 26);
            this.txtB_result.TabIndex = 23;
            // 
            // txtG_result
            // 
            this.txtG_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtG_result.Location = new System.Drawing.Point(832, 150);
            this.txtG_result.Name = "txtG_result";
            this.txtG_result.Size = new System.Drawing.Size(50, 26);
            this.txtG_result.TabIndex = 21;
            // 
            // txtR_result
            // 
            this.txtR_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtR_result.Location = new System.Drawing.Point(832, 115);
            this.txtR_result.Name = "txtR_result";
            this.txtR_result.Size = new System.Drawing.Size(50, 26);
            this.txtR_result.TabIndex = 19;
            // 
            // txtY_result
            // 
            this.txtY_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtY_result.Location = new System.Drawing.Point(832, 80);
            this.txtY_result.Name = "txtY_result";
            this.txtY_result.Size = new System.Drawing.Size(50, 26);
            this.txtY_result.TabIndex = 16;
            // 
            // txtX_result
            // 
            this.txtX_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtX_result.Location = new System.Drawing.Point(832, 45);
            this.txtX_result.Name = "txtX_result";
            this.txtX_result.Size = new System.Drawing.Size(50, 26);
            this.txtX_result.TabIndex = 15;
            // 
            // pnlAction
            // 
            this.pnlAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAction.BackColor = System.Drawing.Color.Transparent;
            this.pnlAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAction.Location = new System.Drawing.Point(12, 381);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(920, 108);
            this.pnlAction.TabIndex = 25;
            // 
            // pnlBase
            // 
            this.pnlBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBase.BackColor = System.Drawing.Color.Transparent;
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBase.Controls.Add(this.lblB_result);
            this.pnlBase.Controls.Add(this.txtPath);
            this.pnlBase.Controls.Add(this.lblG_result);
            this.pnlBase.Controls.Add(this.ptbSoucre);
            this.pnlBase.Controls.Add(this.lblR_result);
            this.pnlBase.Controls.Add(this.btnOpen);
            this.pnlBase.Controls.Add(this.lblY_result);
            this.pnlBase.Controls.Add(this.ptbResult);
            this.pnlBase.Controls.Add(this.lblX_result);
            this.pnlBase.Controls.Add(this.btnSave);
            this.pnlBase.Controls.Add(this.txtB_result);
            this.pnlBase.Controls.Add(this.txtX_source);
            this.pnlBase.Controls.Add(this.txtG_result);
            this.pnlBase.Controls.Add(this.txtY_source);
            this.pnlBase.Controls.Add(this.txtR_result);
            this.pnlBase.Controls.Add(this.txtR_source);
            this.pnlBase.Controls.Add(this.txtY_result);
            this.pnlBase.Controls.Add(this.txtG_source);
            this.pnlBase.Controls.Add(this.txtX_result);
            this.pnlBase.Controls.Add(this.txtB_source);
            this.pnlBase.Controls.Add(this.lblB_source);
            this.pnlBase.Controls.Add(this.lblX_source);
            this.pnlBase.Controls.Add(this.lblG_source);
            this.pnlBase.Controls.Add(this.lblY_source);
            this.pnlBase.Controls.Add(this.lblR_source);
            this.pnlBase.Location = new System.Drawing.Point(12, 12);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(920, 363);
            this.pnlBase.TabIndex = 26;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlAction);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Base";
            ((System.ComponentModel.ISupportInitialize)(this.ptbSoucre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbResult)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox ptbSoucre;
        private System.Windows.Forms.PictureBox ptbResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox txtX_source;
        private System.Windows.Forms.TextBox txtY_source;
        private System.Windows.Forms.Label lblX_source;
        private System.Windows.Forms.Label lblY_source;
        private System.Windows.Forms.TextBox txtR_source;
        private System.Windows.Forms.Label lblR_source;
        private System.Windows.Forms.Label lblG_source;
        private System.Windows.Forms.TextBox txtG_source;
        private System.Windows.Forms.Label lblB_source;
        private System.Windows.Forms.TextBox txtB_source;
        private System.Windows.Forms.Label lblB_result;
        private System.Windows.Forms.Label lblG_result;
        private System.Windows.Forms.Label lblR_result;
        private System.Windows.Forms.Label lblY_result;
        private System.Windows.Forms.Label lblX_result;
        private System.Windows.Forms.TextBox txtB_result;
        private System.Windows.Forms.TextBox txtG_result;
        private System.Windows.Forms.TextBox txtR_result;
        private System.Windows.Forms.TextBox txtY_result;
        private System.Windows.Forms.TextBox txtX_result;
        public System.Windows.Forms.Panel pnlAction;
        public System.Windows.Forms.Panel pnlBase;
    }
}

