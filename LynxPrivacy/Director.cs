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
                if (form.GetType() == typeof(EncryptFile)) {
                    form.Activate();
                    return;
                }
            }
            EncryptFile frmEncryptFile = new EncryptFile();
            frmEncryptFile.MdiParent = this.MdiParent;
            frmEncryptFile.Show();
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(DecryptFile)) {
                    form.Activate();
                    return;
                }
            }
            DecryptFile frmDecryptFile = new DecryptFile();
            frmDecryptFile.MdiParent = this.MdiParent;
            frmDecryptFile.Show();
        }

        private void btnEncryptClipboard_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(EncryptClipboard)) {
                    form.Activate();
                    return;
                }
            }
            EncryptClipboard frmEncryptClipboard = new EncryptClipboard();
            frmEncryptClipboard.MdiParent = this.MdiParent;
            frmEncryptClipboard.Show();
        }

        private void btnDecryptClipboard_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(DecryptClipboard)) {
                    form.Activate();
                    return;
                }
            }
            DecryptClipboard frmDecryptClipboard = new DecryptClipboard();
            frmDecryptClipboard.MdiParent = this.MdiParent;
            frmDecryptClipboard.Show();
        }

    }
}
