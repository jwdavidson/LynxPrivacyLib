namespace LynxPrivacy
{
    partial class CreateKeypairWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wzrdCreateKeyPair = new AeroWizard.WizardControl();
            this.wzrdCreateKpDesc = new AeroWizard.WizardPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wzrdCreateKpUserData = new AeroWizard.WizardPage();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.txtStep2Desc = new System.Windows.Forms.TextBox();
            this.pnlSurname = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.wzrdCreateKpPassphrase = new AeroWizard.WizardPage();
            this.txtStep3Desc = new System.Windows.Forms.TextBox();
            this.txtPassphrase1 = new System.Windows.Forms.TextBox();
            this.txtPassphrase2 = new System.Windows.Forms.TextBox();
            this.pnlPP2 = new System.Windows.Forms.Panel();
            this.pnlPP1 = new System.Windows.Forms.Panel();
            this.pnlQuality = new System.Windows.Forms.Panel();
            this.lblPassphrase2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPassPhrase1 = new System.Windows.Forms.Label();
            this.wzrdCreateKpFinish = new AeroWizard.WizardPage();
            this.txtStep4Desc = new System.Windows.Forms.TextBox();
            this.lblSecretKeyname = new System.Windows.Forms.Label();
            this.txtSecretKeyname = new System.Windows.Forms.TextBox();
            this.lblPublicKeyname = new System.Windows.Forms.Label();
            this.txtPublicKeyname = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wzrdCreateKeyPair)).BeginInit();
            this.wzrdCreateKpDesc.SuspendLayout();
            this.wzrdCreateKpUserData.SuspendLayout();
            this.wzrdCreateKpPassphrase.SuspendLayout();
            this.wzrdCreateKpFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // wzrdCreateKeyPair
            // 
            this.wzrdCreateKeyPair.Location = new System.Drawing.Point(0, 0);
            this.wzrdCreateKeyPair.Name = "wzrdCreateKeyPair";
            this.wzrdCreateKeyPair.Pages.Add(this.wzrdCreateKpDesc);
            this.wzrdCreateKeyPair.Pages.Add(this.wzrdCreateKpUserData);
            this.wzrdCreateKeyPair.Pages.Add(this.wzrdCreateKpPassphrase);
            this.wzrdCreateKeyPair.Pages.Add(this.wzrdCreateKpFinish);
            this.wzrdCreateKeyPair.Size = new System.Drawing.Size(687, 441);
            this.wzrdCreateKeyPair.TabIndex = 0;
            this.wzrdCreateKeyPair.Title = "Create PGP Key Pair Wizard";
            // 
            // wzrdCreateKpDesc
            // 
            this.wzrdCreateKpDesc.Controls.Add(this.textBox1);
            this.wzrdCreateKpDesc.Name = "wzrdCreateKpDesc";
            this.wzrdCreateKpDesc.NextPage = this.wzrdCreateKpUserData;
            this.wzrdCreateKpDesc.Size = new System.Drawing.Size(640, 288);
            this.wzrdCreateKpDesc.TabIndex = 3;
            this.wzrdCreateKpDesc.Text = "Create PGP Key Pair Description (Wizard Step 1 of 4)";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(621, 256);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // wzrdCreateKpUserData
            // 
            this.wzrdCreateKpUserData.Controls.Add(this.lblEmail);
            this.wzrdCreateKpUserData.Controls.Add(this.txtEMail);
            this.wzrdCreateKpUserData.Controls.Add(this.lblSurname);
            this.wzrdCreateKpUserData.Controls.Add(this.txtSurname);
            this.wzrdCreateKpUserData.Controls.Add(this.lblFirstName);
            this.wzrdCreateKpUserData.Controls.Add(this.txtFirstName);
            this.wzrdCreateKpUserData.Controls.Add(this.pnlFirstName);
            this.wzrdCreateKpUserData.Controls.Add(this.txtStep2Desc);
            this.wzrdCreateKpUserData.Controls.Add(this.pnlSurname);
            this.wzrdCreateKpUserData.Controls.Add(this.pnlEmail);
            this.wzrdCreateKpUserData.Name = "wzrdCreateKpUserData";
            this.wzrdCreateKpUserData.NextPage = this.wzrdCreateKpPassphrase;
            this.wzrdCreateKpUserData.Size = new System.Drawing.Size(640, 288);
            this.wzrdCreateKpUserData.TabIndex = 0;
            this.wzrdCreateKpUserData.Tag = "First Name Error";
            this.wzrdCreateKpUserData.Text = "User Information for Key Pair (Wizard Step 2 of 4)";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "EMail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(128, 220);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(367, 23);
            this.txtEMail.TabIndex = 20;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 198);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(54, 15);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(128, 190);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(176, 23);
            this.txtSurname.TabIndex = 18;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 169);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 161);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 23);
            this.txtFirstName.TabIndex = 16;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.BackColor = System.Drawing.Color.Red;
            this.pnlFirstName.Location = new System.Drawing.Point(127, 160);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(178, 25);
            this.pnlFirstName.TabIndex = 13;
            // 
            // txtStep2Desc
            // 
            this.txtStep2Desc.Location = new System.Drawing.Point(21, 16);
            this.txtStep2Desc.Multiline = true;
            this.txtStep2Desc.Name = "txtStep2Desc";
            this.txtStep2Desc.ReadOnly = true;
            this.txtStep2Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStep2Desc.Size = new System.Drawing.Size(597, 128);
            this.txtStep2Desc.TabIndex = 12;
            // 
            // pnlSurname
            // 
            this.pnlSurname.BackColor = System.Drawing.Color.Red;
            this.pnlSurname.Location = new System.Drawing.Point(127, 189);
            this.pnlSurname.Name = "pnlSurname";
            this.pnlSurname.Size = new System.Drawing.Size(178, 25);
            this.pnlSurname.TabIndex = 15;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.Red;
            this.pnlEmail.Location = new System.Drawing.Point(127, 219);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(369, 25);
            this.pnlEmail.TabIndex = 14;
            // 
            // wzrdCreateKpPassphrase
            // 
            this.wzrdCreateKpPassphrase.Controls.Add(this.txtStep3Desc);
            this.wzrdCreateKpPassphrase.Controls.Add(this.txtPassphrase1);
            this.wzrdCreateKpPassphrase.Controls.Add(this.txtPassphrase2);
            this.wzrdCreateKpPassphrase.Controls.Add(this.pnlPP2);
            this.wzrdCreateKpPassphrase.Controls.Add(this.pnlPP1);
            this.wzrdCreateKpPassphrase.Controls.Add(this.pnlQuality);
            this.wzrdCreateKpPassphrase.Controls.Add(this.lblPassphrase2);
            this.wzrdCreateKpPassphrase.Controls.Add(this.checkBox1);
            this.wzrdCreateKpPassphrase.Controls.Add(this.lblPassPhrase1);
            this.wzrdCreateKpPassphrase.Name = "wzrdCreateKpPassphrase";
            this.wzrdCreateKpPassphrase.NextPage = this.wzrdCreateKpFinish;
            this.wzrdCreateKpPassphrase.Size = new System.Drawing.Size(640, 288);
            this.wzrdCreateKpPassphrase.TabIndex = 1;
            this.wzrdCreateKpPassphrase.Text = "Enter Pass Phrase for Secret Key (Wizard Step 3 of 4)";
            // 
            // txtStep3Desc
            // 
            this.txtStep3Desc.Location = new System.Drawing.Point(20, 12);
            this.txtStep3Desc.Multiline = true;
            this.txtStep3Desc.Name = "txtStep3Desc";
            this.txtStep3Desc.ReadOnly = true;
            this.txtStep3Desc.Size = new System.Drawing.Size(605, 158);
            this.txtStep3Desc.TabIndex = 1;
            // 
            // txtPassphrase1
            // 
            this.txtPassphrase1.Location = new System.Drawing.Point(127, 186);
            this.txtPassphrase1.Name = "txtPassphrase1";
            this.txtPassphrase1.PasswordChar = '•';
            this.txtPassphrase1.Size = new System.Drawing.Size(176, 23);
            this.txtPassphrase1.TabIndex = 23;
            this.txtPassphrase1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassphrase1_KeyPress);
            // 
            // txtPassphrase2
            // 
            this.txtPassphrase2.Location = new System.Drawing.Point(127, 219);
            this.txtPassphrase2.Name = "txtPassphrase2";
            this.txtPassphrase2.PasswordChar = '•';
            this.txtPassphrase2.Size = new System.Drawing.Size(176, 23);
            this.txtPassphrase2.TabIndex = 24;
            this.txtPassphrase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassphrase2_KeyPress);
            this.txtPassphrase2.Leave += new System.EventHandler(this.txtPassphrase2_Leave);
            // 
            // pnlPP2
            // 
            this.pnlPP2.BackColor = System.Drawing.Color.Red;
            this.pnlPP2.Location = new System.Drawing.Point(126, 218);
            this.pnlPP2.Name = "pnlPP2";
            this.pnlPP2.Size = new System.Drawing.Size(178, 25);
            this.pnlPP2.TabIndex = 29;
            // 
            // pnlPP1
            // 
            this.pnlPP1.BackColor = System.Drawing.Color.Red;
            this.pnlPP1.Location = new System.Drawing.Point(126, 185);
            this.pnlPP1.Name = "pnlPP1";
            this.pnlPP1.Size = new System.Drawing.Size(178, 25);
            this.pnlPP1.TabIndex = 29;
            // 
            // pnlQuality
            // 
            this.pnlQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlQuality.Location = new System.Drawing.Point(332, 220);
            this.pnlQuality.Name = "pnlQuality";
            this.pnlQuality.Size = new System.Drawing.Size(142, 18);
            this.pnlQuality.TabIndex = 28;
            // 
            // lblPassphrase2
            // 
            this.lblPassphrase2.AutoSize = true;
            this.lblPassphrase2.Location = new System.Drawing.Point(17, 225);
            this.lblPassphrase2.Name = "lblPassphrase2";
            this.lblPassphrase2.Size = new System.Drawing.Size(98, 15);
            this.lblPassphrase2.TabIndex = 27;
            this.lblPassphrase2.Text = "Verify Passphrase";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(330, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 19);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Unhide Passphrase Input";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblPassPhrase1
            // 
            this.lblPassPhrase1.AutoSize = true;
            this.lblPassPhrase1.Location = new System.Drawing.Point(17, 192);
            this.lblPassPhrase1.Name = "lblPassPhrase1";
            this.lblPassPhrase1.Size = new System.Drawing.Size(65, 15);
            this.lblPassPhrase1.TabIndex = 24;
            this.lblPassPhrase1.Text = "Passphrase";
            // 
            // wzrdCreateKpFinish
            // 
            this.wzrdCreateKpFinish.Controls.Add(this.txtStep4Desc);
            this.wzrdCreateKpFinish.Controls.Add(this.lblSecretKeyname);
            this.wzrdCreateKpFinish.Controls.Add(this.txtSecretKeyname);
            this.wzrdCreateKpFinish.Controls.Add(this.lblPublicKeyname);
            this.wzrdCreateKpFinish.Controls.Add(this.txtPublicKeyname);
            this.wzrdCreateKpFinish.Controls.Add(this.btnFolder);
            this.wzrdCreateKpFinish.Controls.Add(this.lblProgressBar);
            this.wzrdCreateKpFinish.Controls.Add(this.progressBar1);
            this.wzrdCreateKpFinish.Controls.Add(this.lblFolder);
            this.wzrdCreateKpFinish.Controls.Add(this.txtFolder);
            this.wzrdCreateKpFinish.IsFinishPage = true;
            this.wzrdCreateKpFinish.Name = "wzrdCreateKpFinish";
            this.wzrdCreateKpFinish.Size = new System.Drawing.Size(640, 288);
            this.wzrdCreateKpFinish.TabIndex = 2;
            this.wzrdCreateKpFinish.Text = "Create and Store PGP Key Pair (Wizard Step 4 of 4)";
            this.wzrdCreateKpFinish.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.wzrdCreateKpFinish_Initialize);
            // 
            // txtStep4Desc
            // 
            this.txtStep4Desc.Location = new System.Drawing.Point(17, 3);
            this.txtStep4Desc.Multiline = true;
            this.txtStep4Desc.Name = "txtStep4Desc";
            this.txtStep4Desc.ReadOnly = true;
            this.txtStep4Desc.Size = new System.Drawing.Size(610, 115);
            this.txtStep4Desc.TabIndex = 29;
            // 
            // lblSecretKeyname
            // 
            this.lblSecretKeyname.AutoSize = true;
            this.lblSecretKeyname.Location = new System.Drawing.Point(14, 192);
            this.lblSecretKeyname.Name = "lblSecretKeyname";
            this.lblSecretKeyname.Size = new System.Drawing.Size(112, 15);
            this.lblSecretKeyname.TabIndex = 28;
            this.lblSecretKeyname.Text = "Secret Key Filename";
            // 
            // txtSecretKeyname
            // 
            this.txtSecretKeyname.Location = new System.Drawing.Point(129, 186);
            this.txtSecretKeyname.Name = "txtSecretKeyname";
            this.txtSecretKeyname.ReadOnly = true;
            this.txtSecretKeyname.Size = new System.Drawing.Size(362, 23);
            this.txtSecretKeyname.TabIndex = 27;
            // 
            // lblPublicKeyname
            // 
            this.lblPublicKeyname.AutoSize = true;
            this.lblPublicKeyname.Location = new System.Drawing.Point(14, 163);
            this.lblPublicKeyname.Name = "lblPublicKeyname";
            this.lblPublicKeyname.Size = new System.Drawing.Size(113, 15);
            this.lblPublicKeyname.TabIndex = 26;
            this.lblPublicKeyname.Text = "Public Key Filename";
            // 
            // txtPublicKeyname
            // 
            this.txtPublicKeyname.Location = new System.Drawing.Point(129, 157);
            this.txtPublicKeyname.Name = "txtPublicKeyname";
            this.txtPublicKeyname.ReadOnly = true;
            this.txtPublicKeyname.Size = new System.Drawing.Size(362, 23);
            this.txtPublicKeyname.TabIndex = 25;
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(510, 124);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(117, 23);
            this.btnFolder.TabIndex = 24;
            this.btnFolder.Text = "Browse Folders ...";
            this.btnFolder.UseVisualStyleBackColor = true;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(14, 231);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(243, 15);
            this.lblProgressBar.TabIndex = 23;
            this.lblProgressBar.Text = "Create and Save Pretty Good Privacy Key Pair";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(17, 259);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(474, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 22;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(14, 132);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(74, 15);
            this.lblFolder.TabIndex = 21;
            this.lblFolder.Text = "Select Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(129, 126);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(362, 23);
            this.txtFolder.TabIndex = 20;
            // 
            // CreateKeypairWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(687, 441);
            this.Controls.Add(this.wzrdCreateKeyPair);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateKeypairWizard";
            this.Text = "Create PGP Key Pair Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.wzrdCreateKeyPair)).EndInit();
            this.wzrdCreateKpDesc.ResumeLayout(false);
            this.wzrdCreateKpDesc.PerformLayout();
            this.wzrdCreateKpUserData.ResumeLayout(false);
            this.wzrdCreateKpUserData.PerformLayout();
            this.wzrdCreateKpPassphrase.ResumeLayout(false);
            this.wzrdCreateKpPassphrase.PerformLayout();
            this.wzrdCreateKpFinish.ResumeLayout(false);
            this.wzrdCreateKpFinish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wzrdCreateKeyPair;
        private AeroWizard.WizardPage wzrdCreateKpUserData;
        private AeroWizard.WizardPage wzrdCreateKpPassphrase;
        private AeroWizard.WizardPage wzrdCreateKpFinish;
        private AeroWizard.WizardPage wzrdCreateKpDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtStep2Desc;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.Panel pnlSurname;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStep3Desc;
        private System.Windows.Forms.TextBox txtPassphrase1;
        private System.Windows.Forms.TextBox txtPassphrase2;
        private System.Windows.Forms.Panel pnlPP2;
        private System.Windows.Forms.Panel pnlPP1;
        private System.Windows.Forms.Panel pnlQuality;
        private System.Windows.Forms.Label lblPassphrase2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblPassPhrase1;
        private System.Windows.Forms.Label lblSecretKeyname;
        private System.Windows.Forms.TextBox txtSecretKeyname;
        private System.Windows.Forms.Label lblPublicKeyname;
        private System.Windows.Forms.TextBox txtPublicKeyname;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtStep4Desc;
    }
}