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
using LynxPrivacyLib;

namespace LynxPrivacy.LocalKeyStoreDialogs
{
    public partial class ImportKeyToKeyStore : Form
    {
        public ImportKeyToKeyStore()
        {
            InitializeComponent();
            lblResult.Visible = false;
        }

        private string m_caller { get; set; }
        internal void SetCaller(string caller)
        {
            m_caller = caller;
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
                txtFileToImport.Text = openFileDialog1.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileToImport.Text)) {
                lblResult.Text = "Please specify file for key to import...";
                lblResult.Visible = true;
            } else
                lblResult.Visible = false;

            if (File.Exists(txtFileToImport.Text)) {
                lblResult.Visible = false;
                ImportKey impKey = new ImportKey();
                string fileName = Path.GetFileName(txtFileToImport.Text);
                string dirName = Path.GetDirectoryName(txtFileToImport.Text);
                if (m_caller == "Secret") {
                    int cnt = impKey.ImportSecretKey(fileName, dirName, Global.keyDb);
                } else {
                    int cnt = impKey.ImportPublicKey(fileName, dirName, Global.keyDb);
                }
                lblResult.Text = "Key imported successfully.";
                lblResult.Visible = true;
            } else {
                lblResult.Text = "File specified does not exist!";
                lblResult.Visible = true;
            }
        }
    }
}
