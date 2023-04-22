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

namespace PdfEncrypter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectSourceFile_Click(object sender, EventArgs e)
        {
            

            if (openSourceFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName;
                FileName = openSourceFileDialog.FileName;
                textBoxSourceFileName.Text = FileName;
            }
        }

        private void buttonStartEncrypt_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Starting Encrypting";

            string inputFilePath = textBoxSourceFileName.Text;
            string outputFilePath = textBoxDestinationFileName.Text;
            string password = textBoxPassword.Text;

            toolStripStatusLabel.Text = "Encrypting...";
            using (var input = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (var output = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                var document = PdfReader.Open(input);
                var securitySettings = document.SecuritySettings;
                securitySettings.UserPassword = password;
                securitySettings.OwnerPassword = password;
                securitySettings.PermitAccessibilityExtractContent = true;
                securitySettings.PermitAnnotations = true;
                securitySettings.PermitAssembleDocument = true;
                securitySettings.PermitExtractContent = true;
                securitySettings.PermitFormsFill = true;
                securitySettings.PermitFullQualityPrint = true;
                securitySettings.PermitModifyDocument = true;
                securitySettings.PermitPrint = true;
                document.Save(output);
            }

            toolStripStatusLabel.Text = "Done...";
        }

        private void buttonSelectDestinationFile_Click(object sender, EventArgs e)
        {
            if(saveDestinationFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName;
                FileName = saveDestinationFileDialog.FileName;
                textBoxDestinationFileName.Text = FileName;
            }
        }
    }
}
