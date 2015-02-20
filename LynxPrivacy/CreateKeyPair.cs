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

namespace LynxPrivacy
{
    public partial class CreateKeyPair : Form
    {

        private char[] m_passphrase1;
        private char[] m_passphrase2;

        private Validations m_Validations;

        public CreateKeyPair()
        {
            InitializeComponent();
            this.CancelButton = btnCancel;
            progressBar1.Visible = false;


            pnlFirstname.Visible = false;
            pnlSurname.Visible = false;
            pnlEmail.Visible = false;

            pnlPP1.Visible = false;
            pnlPP2.Visible = false;
            m_passphrase1 = new char[256];
            m_passphrase2 = new char[256];

            txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;

            m_Validations = new Validations();
        }

        async void btnCreateKepair_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            await Task.Run(() => createKpFinish_CommitAsync(sender, e));
            progressBar1.Visible = false;
            btnCancel.Text = "Close";
        }

        async Task createKpFinish_CommitAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
                txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;
            bool runOk = await LynxPrivacyLib.GenerateKeys.GenerateKeyRing(txtFirstName.Text + " " + txtSurname.Text + " <" + txtEMail.Text + ">",
                m_passphrase1, txtFolder.Text);
            ImportKey impKey = new ImportKey();
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                int cntP = impKey.ImportPublicKey(txtPublicKeyname.Text, txtFolder.Text, keyDB);
                int cntS = impKey.ImportSecretKey(txtSecretKeyname.Text, txtFolder.Text, keyDB);
            }
        }



        int m_pp1Length = 0;
        int m_complexity = 0;

        private void txtPassphrase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) {
                if (e.KeyChar == 8) {
                    m_passphrase1[--m_pp1Length] = '\0';
                } else
                    m_passphrase1[m_pp1Length++] = e.KeyChar;
            }
            CalcComplexity();
        }

        private void CalcComplexity()
        {
            m_complexity = 0;
            bool lowerCase = false;
            bool upperCase = false;
            bool numeric = false;
            bool punctuation = false;
            foreach (byte chr in m_passphrase1) {
                if (chr == 0)
                    break;
                if (System.Char.IsDigit((char)chr)) {
                    if (!numeric) {
                        m_complexity += 4;
                        numeric = true;
                    }
                } else if (System.Char.IsLower((char)chr)) {
                    if (!lowerCase) {
                        m_complexity += 4;
                        lowerCase = true;
                    }
                } else if (System.Char.IsUpper((char)chr)) {
                    if (!upperCase) {
                        m_complexity += 4;
                        upperCase = true;
                    }
                } else if ((!System.Char.IsUpper((char)chr)) && (!System.Char.IsLower((char)chr)) && (!System.Char.IsDigit((char)chr))) {
                    if (!punctuation) {
                        m_complexity += 6;
                        punctuation = true;
                    }
                }
            }
            m_complexity += m_pp1Length;
            if (m_complexity < 15)
                pnlQuality.BackColor = System.Drawing.Color.Red;
            else if (m_complexity < 20)
                pnlQuality.BackColor = System.Drawing.Color.Orange;
            else if (m_complexity < 23)
                pnlQuality.BackColor = System.Drawing.Color.Yellow;
            else if (m_complexity < 25)
                pnlQuality.BackColor = System.Drawing.Color.YellowGreen;
            else if (m_complexity < 28)
                pnlQuality.BackColor = System.Drawing.Color.LightGreen;
            else if (m_complexity < 31)
                pnlQuality.BackColor = System.Drawing.Color.Green;
            else
                pnlQuality.BackColor = System.Drawing.Color.DarkGreen;
        }

        int m_pp2Length = 0;
        private void txtPassphrase2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) {
                if (e.KeyChar == 8) {
                    m_passphrase2[--m_pp2Length] = '\0';
                } else
                    m_passphrase2[m_pp2Length++] = e.KeyChar;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (!m_Validations.FirstNameValid(txtFirstName.Text)) {
                pnlFirstname.Visible = true;
            } else
                pnlFirstname.Visible = false;
        }
        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (!m_Validations.SurnameValid(txtSurname.Text)) {
                pnlSurname.Visible = true;
            } else {
                pnlSurname.Visible = false;
            }
        }
        private void txtEMail_Leave(object sender, EventArgs e)
        {
            if (!m_Validations.EmailValid(txtEMail.Text)) {
                pnlEmail.Visible = true;
            } else {
                pnlEmail.Visible = false;
                txtPublicKeyname.Text = txtEMail.Text + ".public.asc";
                txtSecretKeyname.Text = txtEMail.Text + ".secret.asc";
            }
        }

        private void txtPassphrase2_Leave(object sender, EventArgs e)
        {
            if (!m_passphrase1.SequenceEqual(m_passphrase2)) {
                pnlPP1.Visible = true;
                pnlPP2.Visible = true;
            } else {
                pnlPP1.Visible = false;
                pnlPP2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassphrase1.PasswordChar = checkBox1.Checked ? '\0' : '•';
            txtPassphrase2.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void txtFolder_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
                txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void wzrdCreateKpFinish_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
                txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFolder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
                txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

    }
}
