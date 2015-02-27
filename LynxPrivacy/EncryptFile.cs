using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynxPrivacy
{
    public partial class EncryptFile : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public EncryptFile()
        {
            InitializeComponent();
            Application.ThreadException += Application_ThreadException;
            }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            log.Error(e.Exception.Message, e.Exception);
            DialogResult result = MessageBox.Show(e.Exception.Message, "Error Detected", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                this.Close();
        }

        private void EncryptFile_Load(object sender, EventArgs e)
        {

        }

        private void EncryptFile_Resize(object sender, EventArgs e)
        {

        }

        private void dgvPublicKeys_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvPublicKeys_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dgvPublicKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

        }

        private void btnPubKeyFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOnly_Click(object sender, EventArgs e)
        {

        }

        private void btnEncryptOnly_Click(object sender, EventArgs e)
        {

        }

        private void btnEncryptSign_Click(object sender, EventArgs e)
        {

        }
    }
}
