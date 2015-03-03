using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LynxPrivacyLib;

namespace LynxPrivacy.LocalKeyStoreDialogs
{
    public partial class ExportKeyFromKeyStore : Form
    {
        public ExportKeyFromKeyStore()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private string m_caller { get; set; }
        private int m_keyId { get; set; }

        internal void ConfigExport(string caller, int keyId)
        {
            m_caller = caller;
            m_keyId = keyId;
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
                txtFileForExport.Text = saveFileDialog1.FileName;
        }

        private void btnExportKey_Click(object sender, EventArgs e)
        {
            ExportKey expKey = new ExportKey(Global.keyDb);
            if (m_caller == "Public")
                expKey.ExportDbKey(m_keyId, txtFileForExport.Text);
            else
                expKey.ExportDbKey(m_keyId, txtFileForExport.Text);
            label1.Text = "Key Exported successfully.";
            label1.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
