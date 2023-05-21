using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PdfSharp.Pdf;
using PdfSharp.Pdf.Security;

using PdfSharp.Pdf.IO;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//
enum PdfEncryptionStrength
{
    EncryptionNone,
    Encryption128Bit,
    Encryption40Bit
};

namespace PdfEncrypter
{
    public partial class MainForm : Form
    {
        private Boolean isDestinationFilenameChanged;
        public MainForm()
        {
            InitializeComponent();

            isDestinationFilenameChanged = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkOkayToEncryptPdf();
        }



        private void buttonSelectSourceFile_Click(object sender, EventArgs e)
        {
            //DestinationPDFファイル名の更新を許可する
            isDestinationFilenameChanged = false;

            //ダイアログを開いてファイル名を指定する
            if (OpenSourceFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName;
                FileName = OpenSourceFileDialog.FileName;
                textBoxSourceFileName.Text = FileName;
            }

        }

        private void buttonStartEncrypt_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Starting Encrypting";

            string inputFilePath = textBoxSourceFileName.Text;
            string outputFilePath = textBoxDestinationFileName.Text;
            string userPassword = textBoxUserPassword.Text;
            string ownerPassword = textBoxOwnerPassword.Text;
            PdfEncryptionStrength encryptionStrength = PdfEncryptionStrength.Encryption128Bit;


            //PDFファイルのプロパティ設定をチェックボックスから取得する
            Boolean isPermitAccessibilityExtractContent = checkBoxPermitAccessibilityExtractContent.Checked;
            Boolean isPermitAnnotations = checkBoxPermitAnnotations.Checked;
            Boolean isPermitAssembleDocument = checkBoxPermitAssembleDocument.Checked;
            Boolean isPermitExtractContent = checkBoxPermitExtractContent.Checked;
            Boolean isPermitFormsFill = checkBoxPermitFormsFill.Checked;
            Boolean isPermitFullQualityPrint = checkBoxPermitFullQualityPrint.Checked;
            Boolean isPermitModifyDocument = checkBoxPermitModifyDocument.Checked;
            Boolean isPermitPrint = checkBoxPermitPrint.Checked;

            //暗号強度の設定、ラジオボタンから読み取り
            if(radioButtonEncryptionStrengthNone.Checked == true)
            {
                encryptionStrength = PdfEncryptionStrength.EncryptionNone;
            } 
            else if(radioButtonEncryptionStrength40bit.Checked== true)
            {

                encryptionStrength = PdfEncryptionStrength.Encryption40Bit;
            }
            else if(radioButtonEncryptionStrength128bit.Checked == true)
            {

                encryptionStrength = PdfEncryptionStrength.Encryption128Bit;
            }
            else //デフォルトは128bit
            {
                encryptionStrength = PdfEncryptionStrength.Encryption128Bit;
            }


            toolStripStatusLabel.Text = "Encrypting...";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                //PDFファイルを読み込んでプロパティと暗号化属性を適用
                using (var input = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (var output = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    var document = PdfReader.Open(input);

                    //暗号強度を設定する
                    if(encryptionStrength == PdfEncryptionStrength.EncryptionNone)
                    {
                        document.SecuritySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.None;
                    }
                    else if(encryptionStrength == PdfEncryptionStrength.Encryption40Bit)
                    {
                        document.SecuritySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted40Bit;
                    }
                    else if (encryptionStrength == PdfEncryptionStrength.Encryption128Bit)
                    {
                        document.SecuritySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted128Bit;
                    }
                    else //デフォルトは128bit
                    {
                        document.SecuritySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted128Bit;
                    }

                    var securitySettings = document.SecuritySettings;
                    securitySettings.UserPassword = userPassword;
                    securitySettings.OwnerPassword = ownerPassword;
                    securitySettings.PermitAccessibilityExtractContent = isPermitAccessibilityExtractContent;
                    securitySettings.PermitAnnotations = isPermitAnnotations;
                    securitySettings.PermitAssembleDocument = isPermitAssembleDocument;
                    securitySettings.PermitExtractContent = isPermitExtractContent;
                    securitySettings.PermitFormsFill = isPermitFormsFill;
                    securitySettings.PermitFullQualityPrint = isPermitFullQualityPrint;
                    securitySettings.PermitModifyDocument = isPermitModifyDocument;
                    securitySettings.PermitPrint = isPermitPrint;

                    document.Save(output);
                }
            }
            catch (Exception ex)
            {
                //エラーメッセージを表示する
                MessageBox.Show("An error occured." + "\n ---- \n"+ ex.Message);
            }


            toolStripStatusLabel.Text = "Done...";
            this.Cursor = Cursors.Default;
        }

        private void buttonSelectDestinationFile_Click(object sender, EventArgs e)
        {
            string FileName;

            if(textBoxDestinationFileName.Text != "")
            {
                FileName = textBoxDestinationFileName.Text;
                SaveDestinationFileDialog.FileName = FileName;

            }

            if (SaveDestinationFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileName = SaveDestinationFileDialog.FileName;
                textBoxDestinationFileName.Text = FileName;
            }
        }


        private void textBoxSourceFileName_TextChanged(object sender, EventArgs e)
        {
            //SourceFileNameが指定されたら、Destinationのほうも名前を決めておく
            if(isDestinationFilenameChanged == false)
            {
                //拡張子を取って、それっぽいファイル名にする
                string FileNameRemovedExtension, FileName;
                FileName = textBoxSourceFileName.Text;
                FileNameRemovedExtension = FileName.Split('.')[0];
                textBoxDestinationFileName.Text = FileNameRemovedExtension + "_encrypted.pdf";

            }

            checkOkayToEncryptPdf();
           
        }


        private void textBoxDestinationFileName_KeyDown(object sender, KeyEventArgs e)
        {
            isDestinationFilenameChanged = true;
        }

        private void buttonAboutThisApp_Click(object sender, EventArgs e)
        {
            FormAboutThisApp from = new FormAboutThisApp();

            from.ShowDialog(this);

        }

        private void textBoxDestinationFileName_TextChanged(object sender, EventArgs e)
        {
            checkOkayToEncryptPdf();


        }

        private void checkOkayToEncryptPdf()
        {

            //PDFの暗号化ができるか
            Boolean isOkayToEnvryptPdf = true;
            
            //暗号化先するファイルはすでにある
            if (File.Exists(textBoxSourceFileName.Text) == false)
            {
                //ファイルが無い
                isOkayToEnvryptPdf = false;
                toolStripStatusLabel.Text = "Please specify source pdf file.";
            }

            //暗号化後のファイルはすでにある
            if (File.Exists(textBoxDestinationFileName.Text) == true)
            {
                //ファイルはすでにある
                //isOkayToEnvryptPdf = false;
                toolStripStatusLabel.Text = "Destinatin file alredy exists.";
            }

            //OwnerPasswordが入力されていない
            if(textBoxOwnerPassword.Text == "")
            {
                isOkayToEnvryptPdf = false;
                toolStripStatusLabel.Text = "Please input owner password.";

            }

            if (isOkayToEnvryptPdf == true)
            {
                buttonStartEncrypt.Enabled = isOkayToEnvryptPdf;
                toolStripStatusLabel.Text = "Ready";
            }
            else
            {
                buttonStartEncrypt.Enabled = false;

            }

        }

        private void textBoxOwnerPassword_TextChanged(object sender, EventArgs e)
        {
            checkOkayToEncryptPdf();
        }

        private void textBoxUserPassword_TextChanged(object sender, EventArgs e)
        {
            checkOkayToEncryptPdf();
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            checkBoxPermitAccessibilityExtractContent.Checked = true;
            checkBoxPermitAnnotations.Checked = true;
            checkBoxPermitAssembleDocument.Checked = true;
            checkBoxPermitExtractContent.Checked = true;
            checkBoxPermitFormsFill.Checked = true;
            checkBoxPermitFullQualityPrint.Checked = true;
            checkBoxPermitModifyDocument.Checked = true;
            checkBoxPermitPrint.Checked = true;

        }

        private void buttonUncheckAll_Click(object sender, EventArgs e)
        {
            checkBoxPermitAccessibilityExtractContent.Checked = false;
            checkBoxPermitAnnotations.Checked = false;
            checkBoxPermitAssembleDocument.Checked = false;
            checkBoxPermitExtractContent.Checked = false;
            checkBoxPermitFormsFill.Checked = false;
            checkBoxPermitFullQualityPrint.Checked = false;
            checkBoxPermitModifyDocument.Checked = false;
            checkBoxPermitPrint.Checked = false;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // Get the files that were dragged and dropped onto the form
            string[] DroppedFileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Loop through each file and do something with it
            foreach (string DroppedFileName in DroppedFileNames)
            {
                //DestinationPDFファイル名の更新を許可する
                isDestinationFilenameChanged = false;
                // ドロップされたファイル名をテキストボックスに反映
                textBoxSourceFileName.Text = DroppedFileName;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            //ドロップ中
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //カーソルを変更する
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void checkBoxPermitAccessibilityExtractContent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
