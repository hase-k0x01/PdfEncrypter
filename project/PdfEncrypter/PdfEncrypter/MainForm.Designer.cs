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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectSourceFile = new System.Windows.Forms.Button();
            this.OpenSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDestinationFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSelectDestinationFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDestinationFileName = new System.Windows.Forms.TextBox();
            this.buttonStartEncrypt = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxEncryptOption = new System.Windows.Forms.GroupBox();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.checkBoxPermitModifyDocument = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitPrint = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitFullQualityPrint = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitFormsFill = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitExtractContent = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitAssembleDocument = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitAnnotations = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitAccessibilityExtractContent = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOwnerPassword = new System.Windows.Forms.TextBox();
            this.buttonAboutThisApp = new System.Windows.Forms.Button();
            this.groupBoxEncryptionStrength = new System.Windows.Forms.GroupBox();
            this.radioButtonEncryptionStrengthNone = new System.Windows.Forms.RadioButton();
            this.radioButtonEncryptionStrength40bit = new System.Windows.Forms.RadioButton();
            this.radioButtonEncryptionStrength128bit = new System.Windows.Forms.RadioButton();
            this.StatusStrip1.SuspendLayout();
            this.groupBoxEncryptOption.SuspendLayout();
            this.groupBoxEncryptionStrength.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(10, 41);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(299, 19);
            this.textBoxSourceFileName.TabIndex = 0;
            this.textBoxSourceFileName.TextChanged += new System.EventHandler(this.textBoxSourceFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source PDF File Name:";
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(315, 39);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectSourceFile.TabIndex = 1;
            this.buttonSelectSourceFile.Text = "...";
            this.buttonSelectSourceFile.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFile.Click += new System.EventHandler(this.buttonSelectSourceFile_Click);
            // 
            // OpenSourceFileDialog
            // 
            this.OpenSourceFileDialog.Filter = "PDF File(*.pdf)|*.pdf";
            // 
            // SaveDestinationFileDialog
            // 
            this.SaveDestinationFileDialog.Filter = "PDF File|*.pdf";
            // 
            // buttonSelectDestinationFile
            // 
            this.buttonSelectDestinationFile.Location = new System.Drawing.Point(315, 98);
            this.buttonSelectDestinationFile.Name = "buttonSelectDestinationFile";
            this.buttonSelectDestinationFile.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectDestinationFile.TabIndex = 3;
            this.buttonSelectDestinationFile.Text = "...";
            this.buttonSelectDestinationFile.UseVisualStyleBackColor = true;
            this.buttonSelectDestinationFile.Click += new System.EventHandler(this.buttonSelectDestinationFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination PDF File Name:";
            // 
            // textBoxDestinationFileName
            // 
            this.textBoxDestinationFileName.Location = new System.Drawing.Point(10, 100);
            this.textBoxDestinationFileName.Name = "textBoxDestinationFileName";
            this.textBoxDestinationFileName.Size = new System.Drawing.Size(299, 19);
            this.textBoxDestinationFileName.TabIndex = 2;
            this.textBoxDestinationFileName.TextChanged += new System.EventHandler(this.textBoxDestinationFileName_TextChanged);
            this.textBoxDestinationFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDestinationFileName_KeyDown);
            // 
            // buttonStartEncrypt
            // 
            this.buttonStartEncrypt.Enabled = false;
            this.buttonStartEncrypt.Location = new System.Drawing.Point(10, 223);
            this.buttonStartEncrypt.Name = "buttonStartEncrypt";
            this.buttonStartEncrypt.Size = new System.Drawing.Size(105, 136);
            this.buttonStartEncrypt.TabIndex = 14;
            this.buttonStartEncrypt.Text = "Encrypt";
            this.buttonStartEncrypt.UseVisualStyleBackColor = true;
            this.buttonStartEncrypt.Click += new System.EventHandler(this.buttonStartEncrypt_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(10, 147);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(299, 19);
            this.textBoxUserPassword.TabIndex = 4;
            this.textBoxUserPassword.TextChanged += new System.EventHandler(this.textBoxUserPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Password(Password to Open PDF):";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 413);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(526, 22);
            this.StatusStrip1.TabIndex = 9;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // groupBoxEncryptOption
            // 
            this.groupBoxEncryptOption.Controls.Add(this.buttonUncheckAll);
            this.groupBoxEncryptOption.Controls.Add(this.buttonCheckAll);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitModifyDocument);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitPrint);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitFullQualityPrint);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitFormsFill);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitExtractContent);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitAssembleDocument);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitAnnotations);
            this.groupBoxEncryptOption.Controls.Add(this.checkBoxPermitAccessibilityExtractContent);
            this.groupBoxEncryptOption.Location = new System.Drawing.Point(129, 216);
            this.groupBoxEncryptOption.Name = "groupBoxEncryptOption";
            this.groupBoxEncryptOption.Size = new System.Drawing.Size(385, 136);
            this.groupBoxEncryptOption.TabIndex = 10;
            this.groupBoxEncryptOption.TabStop = false;
            this.groupBoxEncryptOption.Text = "Encrypt Options";
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Location = new System.Drawing.Point(294, 108);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(85, 22);
            this.buttonUncheckAll.TabIndex = 15;
            this.buttonUncheckAll.Text = "UncheckAll";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(205, 108);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(85, 22);
            this.buttonCheckAll.TabIndex = 14;
            this.buttonCheckAll.Text = "CheckAll";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // checkBoxPermitModifyDocument
            // 
            this.checkBoxPermitModifyDocument.AutoSize = true;
            this.checkBoxPermitModifyDocument.Checked = true;
            this.checkBoxPermitModifyDocument.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitModifyDocument.Location = new System.Drawing.Point(11, 105);
            this.checkBoxPermitModifyDocument.Name = "checkBoxPermitModifyDocument";
            this.checkBoxPermitModifyDocument.Size = new System.Drawing.Size(150, 16);
            this.checkBoxPermitModifyDocument.TabIndex = 10;
            this.checkBoxPermitModifyDocument.Text = "Permit Modify Document";
            this.checkBoxPermitModifyDocument.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitPrint
            // 
            this.checkBoxPermitPrint.AutoSize = true;
            this.checkBoxPermitPrint.Checked = true;
            this.checkBoxPermitPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitPrint.Location = new System.Drawing.Point(205, 83);
            this.checkBoxPermitPrint.Name = "checkBoxPermitPrint";
            this.checkBoxPermitPrint.Size = new System.Drawing.Size(85, 16);
            this.checkBoxPermitPrint.TabIndex = 13;
            this.checkBoxPermitPrint.Text = "Permit Print";
            this.checkBoxPermitPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitFullQualityPrint
            // 
            this.checkBoxPermitFullQualityPrint.AutoSize = true;
            this.checkBoxPermitFullQualityPrint.Checked = true;
            this.checkBoxPermitFullQualityPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitFullQualityPrint.Location = new System.Drawing.Point(205, 61);
            this.checkBoxPermitFullQualityPrint.Name = "checkBoxPermitFullQualityPrint";
            this.checkBoxPermitFullQualityPrint.Size = new System.Drawing.Size(148, 16);
            this.checkBoxPermitFullQualityPrint.TabIndex = 12;
            this.checkBoxPermitFullQualityPrint.Text = "Permit Full Quality Print";
            this.checkBoxPermitFullQualityPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitFormsFill
            // 
            this.checkBoxPermitFormsFill.AutoSize = true;
            this.checkBoxPermitFormsFill.Checked = true;
            this.checkBoxPermitFormsFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitFormsFill.Location = new System.Drawing.Point(205, 39);
            this.checkBoxPermitFormsFill.Name = "checkBoxPermitFormsFill";
            this.checkBoxPermitFormsFill.Size = new System.Drawing.Size(113, 16);
            this.checkBoxPermitFormsFill.TabIndex = 11;
            this.checkBoxPermitFormsFill.Text = "Permit Forms Fill";
            this.checkBoxPermitFormsFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitExtractContent
            // 
            this.checkBoxPermitExtractContent.AutoSize = true;
            this.checkBoxPermitExtractContent.Checked = true;
            this.checkBoxPermitExtractContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitExtractContent.Location = new System.Drawing.Point(11, 83);
            this.checkBoxPermitExtractContent.Name = "checkBoxPermitExtractContent";
            this.checkBoxPermitExtractContent.Size = new System.Drawing.Size(142, 16);
            this.checkBoxPermitExtractContent.TabIndex = 9;
            this.checkBoxPermitExtractContent.Text = "Permit Extract Content";
            this.checkBoxPermitExtractContent.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitAssembleDocument
            // 
            this.checkBoxPermitAssembleDocument.AutoSize = true;
            this.checkBoxPermitAssembleDocument.Checked = true;
            this.checkBoxPermitAssembleDocument.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitAssembleDocument.Location = new System.Drawing.Point(11, 61);
            this.checkBoxPermitAssembleDocument.Name = "checkBoxPermitAssembleDocument";
            this.checkBoxPermitAssembleDocument.Size = new System.Drawing.Size(166, 16);
            this.checkBoxPermitAssembleDocument.TabIndex = 8;
            this.checkBoxPermitAssembleDocument.Text = "Permit Assemble Document";
            this.checkBoxPermitAssembleDocument.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitAnnotations
            // 
            this.checkBoxPermitAnnotations.AutoSize = true;
            this.checkBoxPermitAnnotations.Checked = true;
            this.checkBoxPermitAnnotations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitAnnotations.Location = new System.Drawing.Point(11, 39);
            this.checkBoxPermitAnnotations.Name = "checkBoxPermitAnnotations";
            this.checkBoxPermitAnnotations.Size = new System.Drawing.Size(122, 16);
            this.checkBoxPermitAnnotations.TabIndex = 7;
            this.checkBoxPermitAnnotations.Text = "Permit Annotations";
            this.checkBoxPermitAnnotations.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitAccessibilityExtractContent
            // 
            this.checkBoxPermitAccessibilityExtractContent.AutoSize = true;
            this.checkBoxPermitAccessibilityExtractContent.Checked = true;
            this.checkBoxPermitAccessibilityExtractContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPermitAccessibilityExtractContent.Location = new System.Drawing.Point(11, 18);
            this.checkBoxPermitAccessibilityExtractContent.Name = "checkBoxPermitAccessibilityExtractContent";
            this.checkBoxPermitAccessibilityExtractContent.Size = new System.Drawing.Size(212, 16);
            this.checkBoxPermitAccessibilityExtractContent.TabIndex = 6;
            this.checkBoxPermitAccessibilityExtractContent.Text = "Permit Accessibility Extract Content";
            this.checkBoxPermitAccessibilityExtractContent.UseVisualStyleBackColor = true;
            this.checkBoxPermitAccessibilityExtractContent.CheckedChanged += new System.EventHandler(this.checkBoxPermitAccessibilityExtractContent_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Owner  Password(Password to Modify/Full Access):";
            // 
            // textBoxOwnerPassword
            // 
            this.textBoxOwnerPassword.Location = new System.Drawing.Point(10, 191);
            this.textBoxOwnerPassword.Name = "textBoxOwnerPassword";
            this.textBoxOwnerPassword.Size = new System.Drawing.Size(299, 19);
            this.textBoxOwnerPassword.TabIndex = 5;
            this.textBoxOwnerPassword.Text = "password";
            this.textBoxOwnerPassword.TextChanged += new System.EventHandler(this.textBoxOwnerPassword_TextChanged);
            // 
            // buttonAboutThisApp
            // 
            this.buttonAboutThisApp.Location = new System.Drawing.Point(10, 365);
            this.buttonAboutThisApp.Name = "buttonAboutThisApp";
            this.buttonAboutThisApp.Size = new System.Drawing.Size(105, 31);
            this.buttonAboutThisApp.TabIndex = 15;
            this.buttonAboutThisApp.Text = "About This App";
            this.buttonAboutThisApp.UseVisualStyleBackColor = true;
            this.buttonAboutThisApp.Click += new System.EventHandler(this.buttonAboutThisApp_Click);
            // 
            // groupBoxEncryptionStrength
            // 
            this.groupBoxEncryptionStrength.Controls.Add(this.radioButtonEncryptionStrengthNone);
            this.groupBoxEncryptionStrength.Controls.Add(this.radioButtonEncryptionStrength40bit);
            this.groupBoxEncryptionStrength.Controls.Add(this.radioButtonEncryptionStrength128bit);
            this.groupBoxEncryptionStrength.Location = new System.Drawing.Point(129, 358);
            this.groupBoxEncryptionStrength.Name = "groupBoxEncryptionStrength";
            this.groupBoxEncryptionStrength.Size = new System.Drawing.Size(385, 38);
            this.groupBoxEncryptionStrength.TabIndex = 14;
            this.groupBoxEncryptionStrength.TabStop = false;
            this.groupBoxEncryptionStrength.Text = "Encryption Strength";
            // 
            // radioButtonEncryptionStrengthNone
            // 
            this.radioButtonEncryptionStrengthNone.AutoSize = true;
            this.radioButtonEncryptionStrengthNone.Location = new System.Drawing.Point(253, 16);
            this.radioButtonEncryptionStrengthNone.Name = "radioButtonEncryptionStrengthNone";
            this.radioButtonEncryptionStrengthNone.Size = new System.Drawing.Size(49, 16);
            this.radioButtonEncryptionStrengthNone.TabIndex = 2;
            this.radioButtonEncryptionStrengthNone.Text = "None";
            this.radioButtonEncryptionStrengthNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonEncryptionStrength40bit
            // 
            this.radioButtonEncryptionStrength40bit.AutoSize = true;
            this.radioButtonEncryptionStrength40bit.Location = new System.Drawing.Point(134, 16);
            this.radioButtonEncryptionStrength40bit.Name = "radioButtonEncryptionStrength40bit";
            this.radioButtonEncryptionStrength40bit.Size = new System.Drawing.Size(54, 16);
            this.radioButtonEncryptionStrength40bit.TabIndex = 1;
            this.radioButtonEncryptionStrength40bit.Text = "40-bit";
            this.radioButtonEncryptionStrength40bit.UseVisualStyleBackColor = true;
            // 
            // radioButtonEncryptionStrength128bit
            // 
            this.radioButtonEncryptionStrength128bit.AutoSize = true;
            this.radioButtonEncryptionStrength128bit.Checked = true;
            this.radioButtonEncryptionStrength128bit.Location = new System.Drawing.Point(9, 16);
            this.radioButtonEncryptionStrength128bit.Name = "radioButtonEncryptionStrength128bit";
            this.radioButtonEncryptionStrength128bit.Size = new System.Drawing.Size(60, 16);
            this.radioButtonEncryptionStrength128bit.TabIndex = 0;
            this.radioButtonEncryptionStrength128bit.TabStop = true;
            this.radioButtonEncryptionStrength128bit.Text = "128-bit";
            this.radioButtonEncryptionStrength128bit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 435);
            this.Controls.Add(this.groupBoxEncryptionStrength);
            this.Controls.Add(this.buttonAboutThisApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOwnerPassword);
            this.Controls.Add(this.groupBoxEncryptOption);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.buttonStartEncrypt);
            this.Controls.Add(this.buttonSelectDestinationFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDestinationFileName);
            this.Controls.Add(this.buttonSelectSourceFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSourceFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PdfEncrypter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.groupBoxEncryptOption.ResumeLayout(false);
            this.groupBoxEncryptOption.PerformLayout();
            this.groupBoxEncryptionStrength.ResumeLayout(false);
            this.groupBoxEncryptionStrength.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectSourceFile;
        private System.Windows.Forms.OpenFileDialog OpenSourceFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveDestinationFileDialog;
        private System.Windows.Forms.Button buttonSelectDestinationFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestinationFileName;
        private System.Windows.Forms.Button buttonStartEncrypt;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupBoxEncryptOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOwnerPassword;
        private System.Windows.Forms.CheckBox checkBoxPermitPrint;
        private System.Windows.Forms.CheckBox checkBoxPermitFullQualityPrint;
        private System.Windows.Forms.CheckBox checkBoxPermitFormsFill;
        private System.Windows.Forms.CheckBox checkBoxPermitExtractContent;
        private System.Windows.Forms.CheckBox checkBoxPermitAssembleDocument;
        private System.Windows.Forms.CheckBox checkBoxPermitAnnotations;
        private System.Windows.Forms.CheckBox checkBoxPermitAccessibilityExtractContent;
        private System.Windows.Forms.CheckBox checkBoxPermitModifyDocument;
        private System.Windows.Forms.Button buttonAboutThisApp;
        private System.Windows.Forms.GroupBox groupBoxEncryptionStrength;
        private System.Windows.Forms.RadioButton radioButtonEncryptionStrength40bit;
        private System.Windows.Forms.RadioButton radioButtonEncryptionStrength128bit;
        private System.Windows.Forms.RadioButton radioButtonEncryptionStrengthNone;
        private System.Windows.Forms.Button buttonUncheckAll;
        private System.Windows.Forms.Button buttonCheckAll;
    }
}

