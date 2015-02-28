namespace LynxPrivacy
{
    partial class CreateKeyPair
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateKeyPair));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblPassPhrase1 = new System.Windows.Forms.Label();
            this.txtPassphrase1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPassphrase2 = new System.Windows.Forms.Label();
            this.txtPassphrase2 = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblSecretKeyname = new System.Windows.Forms.Label();
            this.txtSecretKeyname = new System.Windows.Forms.TextBox();
            this.lblPublicKeyname = new System.Windows.Forms.Label();
            this.txtPublicKeyname = new System.Windows.Forms.TextBox();
            this.btnCreateKeypair = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlQuality = new System.Windows.Forms.Panel();
            this.pnlSurname = new System.Windows.Forms.Panel();
            this.pnlFirstname = new System.Windows.Forms.Panel();
            this.pnlPP1 = new System.Windows.Forms.Panel();
            this.pnlPP2 = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(50, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(50, 75);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 3;
            this.lbSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(160, 69);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(176, 20);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(33, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "EMail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(160, 99);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(367, 20);
            this.txtEMail.TabIndex = 4;
            this.txtEMail.Leave += new System.EventHandler(this.txtEMail_Leave);
            // 
            // lblPassPhrase1
            // 
            this.lblPassPhrase1.AutoSize = true;
            this.lblPassPhrase1.Location = new System.Drawing.Point(50, 137);
            this.lblPassPhrase1.Name = "lblPassPhrase1";
            this.lblPassPhrase1.Size = new System.Drawing.Size(62, 13);
            this.lblPassPhrase1.TabIndex = 7;
            this.lblPassPhrase1.Text = "Passphrase";
            // 
            // txtPassphrase1
            // 
            this.txtPassphrase1.Location = new System.Drawing.Point(160, 131);
            this.txtPassphrase1.Name = "txtPassphrase1";
            this.txtPassphrase1.PasswordChar = '•';
            this.txtPassphrase1.Size = new System.Drawing.Size(176, 20);
            this.txtPassphrase1.TabIndex = 6;
            this.txtPassphrase1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassphrase1_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(363, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Unhide Passphrase Input";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblPassphrase2
            // 
            this.lblPassphrase2.AutoSize = true;
            this.lblPassphrase2.Location = new System.Drawing.Point(50, 170);
            this.lblPassphrase2.Name = "lblPassphrase2";
            this.lblPassphrase2.Size = new System.Drawing.Size(91, 13);
            this.lblPassphrase2.TabIndex = 10;
            this.lblPassphrase2.Text = "Verify Passphrase";
            // 
            // txtPassphrase2
            // 
            this.txtPassphrase2.Location = new System.Drawing.Point(160, 164);
            this.txtPassphrase2.Name = "txtPassphrase2";
            this.txtPassphrase2.PasswordChar = '•';
            this.txtPassphrase2.Size = new System.Drawing.Size(176, 20);
            this.txtPassphrase2.TabIndex = 7;
            this.txtPassphrase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassphrase2_KeyPress);
            this.txtPassphrase2.Leave += new System.EventHandler(this.txtPassphrase2_Leave);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(50, 232);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(69, 13);
            this.lblFolder.TabIndex = 12;
            this.lblFolder.Text = "Select Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(160, 226);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(367, 20);
            this.txtFolder.TabIndex = 11;
            this.txtFolder.Enter += new System.EventHandler(this.txtFolder_Enter);
            this.txtFolder.Leave += new System.EventHandler(this.txtFolder_Leave);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(53, 359);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(474, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 13;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(50, 331);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(226, 13);
            this.lblProgressBar.TabIndex = 14;
            this.lblProgressBar.Text = "Create and Save Pretty Good Privacy Key Pair";
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(546, 224);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(117, 23);
            this.btnFolder.TabIndex = 15;
            this.btnFolder.Text = "Browse Folders ...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // lblSecretKeyname
            // 
            this.lblSecretKeyname.AutoSize = true;
            this.lblSecretKeyname.Location = new System.Drawing.Point(50, 292);
            this.lblSecretKeyname.Name = "lblSecretKeyname";
            this.lblSecretKeyname.Size = new System.Drawing.Size(104, 13);
            this.lblSecretKeyname.TabIndex = 19;
            this.lblSecretKeyname.Text = "Secret Key Filename";
            // 
            // txtSecretKeyname
            // 
            this.txtSecretKeyname.Location = new System.Drawing.Point(160, 286);
            this.txtSecretKeyname.Name = "txtSecretKeyname";
            this.txtSecretKeyname.ReadOnly = true;
            this.txtSecretKeyname.Size = new System.Drawing.Size(367, 20);
            this.txtSecretKeyname.TabIndex = 18;
            // 
            // lblPublicKeyname
            // 
            this.lblPublicKeyname.AutoSize = true;
            this.lblPublicKeyname.Location = new System.Drawing.Point(50, 263);
            this.lblPublicKeyname.Name = "lblPublicKeyname";
            this.lblPublicKeyname.Size = new System.Drawing.Size(102, 13);
            this.lblPublicKeyname.TabIndex = 17;
            this.lblPublicKeyname.Text = "Public Key Filename";
            // 
            // txtPublicKeyname
            // 
            this.txtPublicKeyname.Location = new System.Drawing.Point(160, 257);
            this.txtPublicKeyname.Name = "txtPublicKeyname";
            this.txtPublicKeyname.ReadOnly = true;
            this.txtPublicKeyname.Size = new System.Drawing.Size(367, 20);
            this.txtPublicKeyname.TabIndex = 16;
            // 
            // btnCreateKeypair
            // 
            this.btnCreateKeypair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKeypair.Location = new System.Drawing.Point(546, 326);
            this.btnCreateKeypair.Name = "btnCreateKeypair";
            this.btnCreateKeypair.Size = new System.Drawing.Size(105, 23);
            this.btnCreateKeypair.TabIndex = 20;
            this.btnCreateKeypair.Text = "Create Keypair";
            this.btnCreateKeypair.UseVisualStyleBackColor = true;
            this.btnCreateKeypair.Click += new System.EventHandler(this.btnCreateKepair_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(546, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlQuality
            // 
            this.pnlQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlQuality.Location = new System.Drawing.Point(365, 165);
            this.pnlQuality.Name = "pnlQuality";
            this.pnlQuality.Size = new System.Drawing.Size(142, 18);
            this.pnlQuality.TabIndex = 22;
            // 
            // pnlSurname
            // 
            this.pnlSurname.BackColor = System.Drawing.Color.Red;
            this.pnlSurname.Location = new System.Drawing.Point(158, 66);
            this.pnlSurname.Name = "pnlSurname";
            this.pnlSurname.Size = new System.Drawing.Size(180, 25);
            this.pnlSurname.TabIndex = 23;
            // 
            // pnlFirstname
            // 
            this.pnlFirstname.BackColor = System.Drawing.Color.Red;
            this.pnlFirstname.Location = new System.Drawing.Point(158, 38);
            this.pnlFirstname.Name = "pnlFirstname";
            this.pnlFirstname.Size = new System.Drawing.Size(180, 25);
            this.pnlFirstname.TabIndex = 24;
            // 
            // pnlPP1
            // 
            this.pnlPP1.BackColor = System.Drawing.Color.Red;
            this.pnlPP1.Location = new System.Drawing.Point(158, 127);
            this.pnlPP1.Name = "pnlPP1";
            this.pnlPP1.Size = new System.Drawing.Size(180, 27);
            this.pnlPP1.TabIndex = 24;
            // 
            // pnlPP2
            // 
            this.pnlPP2.BackColor = System.Drawing.Color.Red;
            this.pnlPP2.Location = new System.Drawing.Point(158, 161);
            this.pnlPP2.Name = "pnlPP2";
            this.pnlPP2.Size = new System.Drawing.Size(180, 27);
            this.pnlPP2.TabIndex = 24;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.Red;
            this.pnlEmail.Location = new System.Drawing.Point(158, 96);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(371, 25);
            this.pnlEmail.TabIndex = 24;
            // 
            // CreateKeyPair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 394);
            this.Controls.Add(this.pnlQuality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateKeypair);
            this.Controls.Add(this.lblSecretKeyname);
            this.Controls.Add(this.txtSecretKeyname);
            this.Controls.Add(this.lblPublicKeyname);
            this.Controls.Add(this.txtPublicKeyname);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblPassphrase2);
            this.Controls.Add(this.txtPassphrase2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPassPhrase1);
            this.Controls.Add(this.txtPassphrase1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.pnlPP2);
            this.Controls.Add(this.pnlPP1);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlSurname);
            this.Controls.Add(this.pnlFirstname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateKeyPair";
            this.Text = "Create Key Pair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateKeyPair_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblPassPhrase1;
        private System.Windows.Forms.TextBox txtPassphrase1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblPassphrase2;
        private System.Windows.Forms.TextBox txtPassphrase2;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lblSecretKeyname;
        private System.Windows.Forms.TextBox txtSecretKeyname;
        private System.Windows.Forms.Label lblPublicKeyname;
        private System.Windows.Forms.TextBox txtPublicKeyname;
        private System.Windows.Forms.Button btnCreateKeypair;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlQuality;
        private System.Windows.Forms.Panel pnlSurname;
        private System.Windows.Forms.Panel pnlFirstname;
        private System.Windows.Forms.Panel pnlPP1;
        private System.Windows.Forms.Panel pnlPP2;
        private System.Windows.Forms.Panel pnlEmail;
    }
}