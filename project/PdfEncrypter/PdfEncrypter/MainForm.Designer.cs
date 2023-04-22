namespace PdfEncrypter
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectSourceFile = new System.Windows.Forms.Button();
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDestinationFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSelectDestinationFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDestinationFileName = new System.Windows.Forms.TextBox();
            this.buttonStartEncrypt = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(10, 59);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(299, 19);
            this.textBoxSourceFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source PDF File Name:";
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(315, 57);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectSourceFile.TabIndex = 1;
            this.buttonSelectSourceFile.Text = "...";
            this.buttonSelectSourceFile.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFile.Click += new System.EventHandler(this.buttonSelectSourceFile_Click);
            // 
            // openSourceFileDialog
            // 
            this.openSourceFileDialog.Filter = "PDF File(*.pdf)|*.pdf";
            // 
            // saveDestinationFileDialog
            // 
            this.saveDestinationFileDialog.Filter = "PDF File|*.pdf";
            // 
            // buttonSelectDestinationFile
            // 
            this.buttonSelectDestinationFile.Location = new System.Drawing.Point(315, 116);
            this.buttonSelectDestinationFile.Name = "buttonSelectDestinationFile";
            this.buttonSelectDestinationFile.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectDestinationFile.TabIndex = 4;
            this.buttonSelectDestinationFile.Text = "...";
            this.buttonSelectDestinationFile.UseVisualStyleBackColor = true;
            this.buttonSelectDestinationFile.Click += new System.EventHandler(this.buttonSelectDestinationFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination PDF File Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDestinationFileName
            // 
            this.textBoxDestinationFileName.Location = new System.Drawing.Point(10, 118);
            this.textBoxDestinationFileName.Name = "textBoxDestinationFileName";
            this.textBoxDestinationFileName.Size = new System.Drawing.Size(299, 19);
            this.textBoxDestinationFileName.TabIndex = 3;
            // 
            // buttonStartEncrypt
            // 
            this.buttonStartEncrypt.Location = new System.Drawing.Point(10, 212);
            this.buttonStartEncrypt.Name = "buttonStartEncrypt";
            this.buttonStartEncrypt.Size = new System.Drawing.Size(88, 55);
            this.buttonStartEncrypt.TabIndex = 6;
            this.buttonStartEncrypt.Text = "Encrypt";
            this.buttonStartEncrypt.UseVisualStyleBackColor = true;
            this.buttonStartEncrypt.Click += new System.EventHandler(this.buttonStartEncrypt_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(10, 165);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(299, 19);
            this.textBoxPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(367, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 314);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonStartEncrypt);
            this.Controls.Add(this.buttonSelectDestinationFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDestinationFileName);
            this.Controls.Add(this.buttonSelectSourceFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSourceFileName);
            this.Name = "MainForm";
            this.Text = "PdfEncrypter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectSourceFile;
        private System.Windows.Forms.OpenFileDialog openSourceFileDialog;
        private System.Windows.Forms.SaveFileDialog saveDestinationFileDialog;
        private System.Windows.Forms.Button buttonSelectDestinationFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestinationFileName;
        private System.Windows.Forms.Button buttonStartEncrypt;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

