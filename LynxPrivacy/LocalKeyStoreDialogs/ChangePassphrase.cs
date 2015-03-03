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
    public partial class ChangePassphrase : Form
    {
        public ChangePassphrase()
        {
            InitializeComponent();
            pnlPP0.Visible = false;
            pnlPP1.Visible = false;
            pnlPP2.Visible = false;
            lblResult.Visible = false;
        }

        private int m_keyId { get; set; }
        internal void ConfigChangePassphrase(int keyId)
        {
            m_keyId = keyId;
        }


        char[] m_passphrase1;
        int m_pp1Length = 0;
        int m_complexity = 0;

        private void txtNewPassphrase1_KeyPress(object sender, KeyPressEventArgs e)
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

        char[] m_passphrase2;
        int m_pp2Length = 0;
        private void txtNewPassphrase2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) {
                if (e.KeyChar == 8) {
                    m_passphrase2[--m_pp2Length] = '\0';
                } else
                    m_passphrase2[m_pp2Length++] = e.KeyChar;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtOrigPassphrase.PasswordChar = checkBox1.Checked ? '\0' : '•';
            txtNewPassphrase1.PasswordChar = checkBox1.Checked ? '\0' : '•';
            txtNewPassphrase2.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void txtOrigPassphrase_Leave(object sender, EventArgs e)
        {
            if (m_pp0Length > 0) {
                pnlPP0.Visible = false;
            } else {
                pnlPP0.Visible = true;
            }
        }

        private void txtNewPassphrase1_Leave(object sender, EventArgs e)
        {
            if (!m_passphrase1.SequenceEqual(m_passphrase2)) {
                pnlPP1.Visible = true;
                pnlPP2.Visible = true;
            } else {
                pnlPP1.Visible = false;
                pnlPP2.Visible = false;
            }
        }

        private void txtNewPassphrase2_Leave(object sender, EventArgs e)
        {
            if (!m_passphrase1.SequenceEqual(m_passphrase2)) {
                pnlPP1.Visible = true;
                pnlPP2.Visible = true;
            } else {
                pnlPP1.Visible = false;
                pnlPP2.Visible = false;
            }
        }

        char[] m_passphrase0;
        int m_pp0Length = 0;
        private void txtOrigPassphrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) {
                if (e.KeyChar == 8) {
                    m_passphrase0[--m_pp0Length] = '\0';
                } else
                    m_passphrase0[m_pp0Length++] = e.KeyChar;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string m_Trust { get; set; }
        private void ChangePassphrase_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            KeyStores key = Global.keyDb.KeyStores.Find(m_keyId);
            txtName.Text = key.KeyUsers.First().UserName;
            txtEmail.Text = key.KeyUsers.First().Email;
            m_Trust = key.OwnerTrust;
            StringBuilder buildFingerprint = new StringBuilder();
            for (int x = 0; x < key.Fingerprint.Length; x++) {
                buildFingerprint.Append(string.Format("{0} ", key.Fingerprint[x].ToString("X2")));
            }
            txtFingerprint.Text = buildFingerprint.ToString().TrimEnd();
            Cursor.Current = Cursors.Default;
        }

        private void btnChangePassphrase_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            RetrievePgpKeys keySet = new RetrievePgpKeys(txtEmail.Text, true, Global.keyDb);
            PgpSecretKeyPassphraseChange.KeyChangePassphrase(keySet.SecretKey, m_passphrase0,
                m_passphrase1, Global.keyDb, string.Empty);
            lblResult.Text = "Passphrase updated successfully.";
            lblResult.Visible = true;
            Cursor.Current = Cursors.Default;
        }




    }
}
