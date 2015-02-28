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
    public partial class Director : Form
    {
        private bool m_useWizards = false;
        public Director()
        {
            InitializeComponent();
        }

        private void btnFormCreateKeypair_Click(object sender, EventArgs e)
        {
            if (m_useWizards) {
                foreach (Form form in Application.OpenForms) {
                    if (form.GetType() == typeof(CreateKeypairWizard)) {
                        form.Activate();
                        return;
                    }
                }
                CreateKeypairWizard frmCreateKeypair = new CreateKeypairWizard();
                frmCreateKeypair.MdiParent = this.MdiParent;
                frmCreateKeypair.Show();
            } else {
                foreach (Form form in Application.OpenForms) {
                    if (form.GetType() == typeof(CreateKeyPair)) {
                        form.Activate();
                        return;
                    }
                }
                CreateKeyPair frmCreateKeypair = new CreateKeyPair();
                frmCreateKeypair.MdiParent = this.MdiParent;
                frmCreateKeypair.Show();
            }
        }

        private void chkUseWizards_CheckedChanged(object sender, EventArgs e)
        {
            m_useWizards = chkUseWizards.Checked;
        }

        private void btnLocalKeystore_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(LocalKeyStore)) {
                    form.Activate();
                    return;
                }
            }
            LocalKeyStore frmLocalKeyStore = new LocalKeyStore();
            frmLocalKeyStore.MdiParent = this.MdiParent;
            frmLocalKeyStore.Show();
        }

        private void btnRemoteKeyserver_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(KeyServer)) {
                    form.Activate();
                    return;
                }
            }
            KeyServer frmKeyServer = new KeyServer();
            frmKeyServer.MdiParent = this.MdiParent;
            frmKeyServer.Show();
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(KeyServer)) {
                    form.Activate();
                    return;
                }
            }
            EncryptFile frmEncryptFile = new EncryptFile();
            frmEncryptFile.MdiParent = this.MdiParent;
            frmEncryptFile.Show();
        }

    }
}
