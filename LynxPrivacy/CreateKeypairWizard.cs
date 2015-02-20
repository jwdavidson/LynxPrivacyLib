using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LynxPrivacyLib;

namespace LynxPrivacy
{
    public partial class CreateKeypairWizard : Form
    {

        private Validations m_Validations;
        public CreateKeypairWizard()
        {
            InitializeComponent();
            
            progressBar1.Visible = false;

            textBox1.Text = buildWizardDescription();
            textBox1.SelectionStart = 0;

            txtStep2Desc.Text = buildStep2Desc();
            txtStep2Desc.SelectionStart = 0;
            wzrdCreateKpUserData.Commit += new EventHandler<AeroWizard.WizardPageConfirmEventArgs>(wzrdCreateKpUserData_Commit);
            wzrdCreateKeyPair.Cancelling += wzrdCreateKeyPair_Cancelling;
            pnlFirstName.Visible = false;
            pnlSurname.Visible = false;
            pnlEmail.Visible = false;

            txtStep3Desc.Text = buildStep3Desc();
            txtStep3Desc.SelectionStart = 0;
            wzrdCreateKpPassphrase.Commit += new EventHandler<AeroWizard.WizardPageConfirmEventArgs>(wzrdCreateKpPassphrase_Commit);
            pnlPP1.Visible = false;
            pnlPP2.Visible = false;
            m_passphrase1 = new char[256];
            m_passphrase2 = new char[256];

            txtStep4Desc.Text = buildStep4Desc();
            txtStep4Desc.SelectionStart = 0;
            wzrdCreateKpFinish.Commit += new EventHandler<AeroWizard.WizardPageConfirmEventArgs>(wzrdCreateKpFinish_Commit);
            txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;

            m_Validations = new Validations();
        }

        void wzrdCreateKeyPair_Cancelling(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Close();
        }



         async void wzrdCreateKpFinish_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            progressBar1.Visible = true;
            await Task.Run(() => wzrdCreateKpFinish_CommitAsync(sender, e));
            progressBar1.Visible = false;
            wzrdCreateKeyPair.CancelButtonText = "Close";
        }

        async Task wzrdCreateKpFinish_CommitAsync(object sender, AeroWizard.WizardPageConfirmEventArgs e)
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

        void wzrdCreateKpPassphrase_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (!m_passphrase1.SequenceEqual(m_passphrase2)) {
                e.Cancel = true;
                pnlPP1.Visible = true;
                pnlPP2.Visible = true;
            } else {
                pnlPP1.Visible = false;
                pnlPP2.Visible = false;
            }
        }

        void wzrdCreateKpUserData_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (!m_Validations.FirstNameValid(txtFirstName.Text)) {
                e.Cancel = true;
                pnlFirstName.Visible = true;
            } else {
                pnlFirstName.Visible = false;
            }
            if (!m_Validations.SurnameValid(txtSurname.Text)) {
                e.Cancel = true;
                pnlSurname.Visible = true;
            } else {
                pnlSurname.Visible = false;
            }
            if (!m_Validations.EmailValid(txtEMail.Text)) {
                e.Cancel = true;
                pnlEmail.Visible = true;
            } else {
                pnlEmail.Visible = false;
            }
        }


        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (!m_Validations.FirstNameValid(txtFirstName.Text)) {
                pnlFirstName.Visible = true;
            } else
                pnlFirstName.Visible = false;
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
            }
        }

        char[] m_passphrase1;
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

        char[] m_passphrase2;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassphrase1.PasswordChar = checkBox1.Checked ? '\0' : '•';
            txtPassphrase2.PasswordChar = checkBox1.Checked ? '\0' : '•';
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

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
        }


        private string buildWizardDescription()
        {
            StringBuilder strDesc = new StringBuilder();
            strDesc.Append("The Pretty Good Privacy tool allows files and email content to be encrypted using Public Key Cryptogrophy. ");
            strDesc.Append("Public Key Cryptography use a Public and Private key to encrypt and decrypt content. ");
            strDesc.Append("It also provides assurance of data integrity and validation of the originator of the content.");
            strDesc.AppendLine("");
            strDesc.AppendLine("");
            strDesc.Append("In order for this to work you must have your own keys. ");
            strDesc.Append("This process will create the Public and Private keys for you with the necessary values for you to be able to send and receive encrypted content. ");
            strDesc.AppendLine("");
            strDesc.AppendLine("");
            strDesc.Append("The Public Key is what you let friends have to send you encrypted content. ");
            strDesc.Append("Normally this is sent to a keyserver where they can look it up, but you can also send them the key as an attachment. ");
            strDesc.Append("It is not necessary to protect the Public Key in any way, as it is designed to not require protection.");
            strDesc.AppendLine("");
            strDesc.AppendLine("");
            strDesc.Append("The Private Key is protected by a pass phrase. ");
            strDesc.Append("You will be required to enter this value as part of creating these keys. ");
            strDesc.Append("You must remember this pass phrase as it is not possible to determine what the value was if you forget it.");
            strDesc.Append("This pass phrase should be difficult for anyone to guess and there will be an indication of how good the selection is when you enter the value. ");
            strDesc.Append("It is possible to change the pass phrase at a later date, but you must know the original pass phrase to do this. ");
            strDesc.Append("");


            return strDesc.ToString();
        }

        private string buildStep2Desc()
        {
            StringBuilder strDesc = new StringBuilder();
            strDesc.Append("The User Identification section is where you specify details about yourself so that the keys can be used properly. ");
            strDesc.Append("The First Name and Surname fields are required. They should contain the names that you use on the Internet. ");
            strDesc.Append("The First Name field may have more than one name (John Walker) or a name and an initial (John W.)");
            strDesc.Append("The Surname field should have your family name (Davidson). ");
            strDesc.Append("If you use a psueonym on the intenet then you will have to determine how best to fill these fields. ");
            strDesc.AppendLine("");
            strDesc.AppendLine("");
            strDesc.Append("The email address should have the email address you want to use to send and receive encrypted material.");
            strDesc.Append("The email address normally looks like - jwdavidson@gmail.com ");
            strDesc.Append("If you have more than one email address you will be able to add this as well once you graduate out of the wizard supported mode. ");
            strDesc.AppendLine("");
            strDesc.AppendLine("");
            strDesc.Append("When the key is created uthe User identifification section is put together to make a string that looks like - ");
            strDesc.Append("\"John W. Davidson <jwdavidson@gmail.com>\"");


            return strDesc.ToString();
        }

        private string buildStep3Desc()
        {
            StringBuilder strDesc = new StringBuilder();
            strDesc.Append("The pass phrase is the lock on your Private Key. The colour indicator is an attempt to show you the quality of the lock. ");
            strDesc.Append("Both pass phrases must be indentical before the process will allow you to move to the next step. ");
            strDesc.Append("If you forget this pass phrase it will be impossible to decrypt any content that was encrypted for that Private Key, ");
            strDesc.Append("and you will not be able to reset the pass phrase to a new value without the original value. ");
            strDesc.AppendLine("");


            return strDesc.ToString();
        }
        private string buildStep4Desc()
        {
            StringBuilder strDesc = new StringBuilder();
            strDesc.Append("The generation of the 2 key files takes a long time, 3 to 5 minutes at a minimum. It may be more. ");
            strDesc.Append("The length of time is necessary to create keys that 4096-bits in length. These should be secure for about 7 - 10 years. ");
            strDesc.Append("The progress bar that is displayed while working will disappear when the process has completed. ");
            strDesc.Append("Fortunately, this is not a process that is run frequently. ");
            strDesc.AppendLine("");
            strDesc.AppendLine("");
            strDesc.Append("The directory shown is the default location for storing the keys, but you may change it to any folder that you want. ");
            strDesc.Append("The key names are not changable, but are shown to you so that you may copy them as necessary.");
            strDesc.AppendLine("");


            return strDesc.ToString();
        }

        private void wzrdCreateKpFinish_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            txtPublicKeyname.Text = txtEMail.Text + ".public.asc";
            txtSecretKeyname.Text = txtEMail.Text + ".secret.asc";
        }

        private void txtFolder_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void txtFolder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
                txtFolder.Text = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
