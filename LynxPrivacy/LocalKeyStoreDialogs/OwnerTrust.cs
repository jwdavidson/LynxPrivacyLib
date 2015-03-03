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
    public partial class OwnerTrust : Form
    {
        public OwnerTrust()
        {
            InitializeComponent();
            label4.Text = "This is a known or suspected problem where communications from, or to, the email address are compromised or entirely untrustworthy.";
            label5.Text = "This is the default for an unknown email address or someone you are just starting to communicate with.";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Visible = false;
        }

        private int m_keyId { get; set; }
        private string m_keyType { get; set; }
        internal void ConfigOwnerTrust(string keyType, int keyId)
        {
            m_keyType = keyType;
            m_keyId = keyId;
            if (keyType == "Public") {
                rdoKnownProblem.Enabled = true;
                rdoNoTrust.Enabled = true;
                rdoMinimalTrust.Enabled = true;
                rdoFullTrust.Enabled = true;
                chkUltimateTrust.Enabled = false;
            } else {
                rdoKnownProblem.Enabled = false;
                rdoNoTrust.Enabled = false;
                rdoMinimalTrust.Enabled = false;
                rdoFullTrust.Enabled = false;
                chkUltimateTrust.Enabled = true;
            }
        }

        private KeyStores m_key { get; set; }
        private string m_trust { get; set; }
        private void OwnerTrust_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            KeyStores key = Global.keyDb.KeyStores.Find(m_keyId);
            m_key = key;
            txtName.Text = key.KeyUsers.First().UserName;
            txtEmail.Text = key.KeyUsers.First().Email;
            StringBuilder buildFingerprint = new StringBuilder();
            for (int x = 0; x < key.Fingerprint.Length; x++) {
                buildFingerprint.Append(string.Format("{0} ", key.Fingerprint[x].ToString("X2")));
            }
            txtFingerprint.Text = buildFingerprint.ToString().TrimEnd();
            m_trust = key.OwnerTrust;
            switch (m_trust) {
                case "ultimate":
                    chkUltimateTrust.Checked = true;
                    break;
                case "full":
                    rdoFullTrust.Checked = true;
                    break;
                case "marginal":
                    rdoMinimalTrust.Checked = true;
                    break;
                case "unknown":
                    rdoNoTrust.Checked = true;
                    break;
                case "never":
                    rdoKnownProblem.Checked = true;
                    break;
                default:
                    if (m_keyType == "Public")
                        rdoNoTrust.Checked = true;
                    break;
            }
            Cursor.Current = Cursors.Default;
        }

        private string m_newTrust { get; set; }
        private void chkUltimateTrust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUltimateTrust.Checked)
                m_newTrust = "ultimate";
            else
                m_newTrust = "";
        }

        private void btnSetTrustLevel_Click(object sender, EventArgs e)
        {
            m_key.OwnerTrust = m_newTrust;
            Global.keyDb.SaveChanges();
            label9.Text = "Owner Trust for the key updated successfully.";
            label9.Visible = true;
        }

        private void rdoKnownProblem_Click(object sender, EventArgs e)
        {
            m_newTrust = "never";
        }

        private void rdoNoTrust_Click(object sender, EventArgs e)
        {
            m_newTrust = "unknown";
        }

        private void rdoMinimalTrust_Click(object sender, EventArgs e)
        {
            m_newTrust = "marginal";
        }

        private void rdoFullTrust_Click(object sender, EventArgs e)
        {
            m_newTrust = "full";
        }
        
    }
}
