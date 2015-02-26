namespace LynxPrivacy
{
    partial class EncryptFile
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblChooseFile = new System.Windows.Forms.Label();
            this.txtChooseFile = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnPubKeyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubKeyFilter = new System.Windows.Forms.TextBox();
            this.dgvPublicKeys = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblChoosePublicKeys = new System.Windows.Forms.Label();
            this.lblSelectSender = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.lblSaveFile = new System.Windows.Forms.Label();
            this.btnSignOnly = new System.Windows.Forms.Button();
            this.btnEncryptOnly = new System.Windows.Forms.Button();
            this.btnEncryptSign = new System.Windows.Forms.Button();
            this.keyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keyUserIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyStoreIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encryptionTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keySizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDaysDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMasterKeyDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSigningKeyDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isEncryptionKeyDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fingerprintDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerTrustDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keyUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyStoreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encryptionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keySizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMasterKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSigningKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isEncryptionKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fingerprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerTrustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.Location = new System.Drawing.Point(20, 16);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(65, 13);
            this.lblChooseFile.TabIndex = 0;
            this.lblChooseFile.Text = "Choose File:";
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Location = new System.Drawing.Point(102, 14);
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.Size = new System.Drawing.Size(429, 20);
            this.txtChooseFile.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(552, 14);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(130, 21);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Select File ...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            // 
            // btnPubKeyFilter
            // 
            this.btnPubKeyFilter.Location = new System.Drawing.Point(363, 57);
            this.btnPubKeyFilter.Name = "btnPubKeyFilter";
            this.btnPubKeyFilter.Size = new System.Drawing.Size(86, 23);
            this.btnPubKeyFilter.TabIndex = 11;
            this.btnPubKeyFilter.Text = "Filter";
            this.btnPubKeyFilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Filter:";
            // 
            // txtPubKeyFilter
            // 
            this.txtPubKeyFilter.Location = new System.Drawing.Point(228, 57);
            this.txtPubKeyFilter.Name = "txtPubKeyFilter";
            this.txtPubKeyFilter.Size = new System.Drawing.Size(117, 20);
            this.txtPubKeyFilter.TabIndex = 9;
            this.txtPubKeyFilter.Tag = "Enter Filter Data";
            // 
            // dgvPublicKeys
            // 
            this.dgvPublicKeys.AutoGenerateColumns = false;
            this.dgvPublicKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected1,
            this.keyUserIdDataGridViewTextBoxColumn,
            this.keyStoreIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.encryptionTypeDataGridViewTextBoxColumn,
            this.keySizeDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.validDaysDataGridViewTextBoxColumn,
            this.isMasterKeyDataGridViewCheckBoxColumn,
            this.isSigningKeyDataGridViewCheckBoxColumn,
            this.isEncryptionKeyDataGridViewCheckBoxColumn,
            this.fingerprintDataGridViewTextBoxColumn,
            this.ownerTrustDataGridViewTextBoxColumn,
            this.keyTypeDataGridViewTextBoxColumn});
            this.dgvPublicKeys.DataSource = this.keyViewBindingSource;
            this.dgvPublicKeys.Location = new System.Drawing.Point(14, 86);
            this.dgvPublicKeys.Name = "dgvPublicKeys";
            this.dgvPublicKeys.Size = new System.Drawing.Size(724, 110);
            this.dgvPublicKeys.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.keyUserIdDataGridViewTextBoxColumn1,
            this.keyStoreIdDataGridViewTextBoxColumn1,
            this.userNameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.encryptionTypeDataGridViewTextBoxColumn1,
            this.keySizeDataGridViewTextBoxColumn1,
            this.creationTimeDataGridViewTextBoxColumn1,
            this.validDaysDataGridViewTextBoxColumn1,
            this.isMasterKeyDataGridViewCheckBoxColumn1,
            this.isSigningKeyDataGridViewCheckBoxColumn1,
            this.isEncryptionKeyDataGridViewCheckBoxColumn1,
            this.fingerprintDataGridViewTextBoxColumn1,
            this.ownerTrustDataGridViewTextBoxColumn1,
            this.keyTypeDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.keyViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 78);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblChoosePublicKeys
            // 
            this.lblChoosePublicKeys.AutoSize = true;
            this.lblChoosePublicKeys.Location = new System.Drawing.Point(20, 64);
            this.lblChoosePublicKeys.Name = "lblChoosePublicKeys";
            this.lblChoosePublicKeys.Size = new System.Drawing.Size(90, 13);
            this.lblChoosePublicKeys.TabIndex = 14;
            this.lblChoosePublicKeys.Text = "Select Recipients";
            // 
            // lblSelectSender
            // 
            this.lblSelectSender.AutoSize = true;
            this.lblSelectSender.Location = new System.Drawing.Point(27, 215);
            this.lblSelectSender.Name = "lblSelectSender";
            this.lblSelectSender.Size = new System.Drawing.Size(74, 13);
            this.lblSelectSender.TabIndex = 15;
            this.lblSelectSender.Text = "Select Sender";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(552, 328);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(130, 21);
            this.btnSaveFile.TabIndex = 18;
            this.btnSaveFile.Text = "Save File ...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(102, 328);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(429, 20);
            this.txtSaveFile.TabIndex = 17;
            // 
            // lblSaveFile
            // 
            this.lblSaveFile.AutoSize = true;
            this.lblSaveFile.Location = new System.Drawing.Point(20, 330);
            this.lblSaveFile.Name = "lblSaveFile";
            this.lblSaveFile.Size = new System.Drawing.Size(54, 13);
            this.lblSaveFile.TabIndex = 16;
            this.lblSaveFile.Text = "Save File:";
            // 
            // btnSignOnly
            // 
            this.btnSignOnly.Location = new System.Drawing.Point(31, 367);
            this.btnSignOnly.Name = "btnSignOnly";
            this.btnSignOnly.Size = new System.Drawing.Size(78, 25);
            this.btnSignOnly.TabIndex = 19;
            this.btnSignOnly.Text = "Sign Only";
            this.btnSignOnly.UseVisualStyleBackColor = true;
            // 
            // btnEncryptOnly
            // 
            this.btnEncryptOnly.Location = new System.Drawing.Point(126, 367);
            this.btnEncryptOnly.Name = "btnEncryptOnly";
            this.btnEncryptOnly.Size = new System.Drawing.Size(78, 25);
            this.btnEncryptOnly.TabIndex = 20;
            this.btnEncryptOnly.Text = "Encrypt Only";
            this.btnEncryptOnly.UseVisualStyleBackColor = true;
            // 
            // btnEncryptSign
            // 
            this.btnEncryptSign.Location = new System.Drawing.Point(228, 367);
            this.btnEncryptSign.Name = "btnEncryptSign";
            this.btnEncryptSign.Size = new System.Drawing.Size(108, 25);
            this.btnEncryptSign.TabIndex = 21;
            this.btnEncryptSign.Text = "Encrypt and Sign";
            this.btnEncryptSign.UseVisualStyleBackColor = true;
            // 
            // keyViewBindingSource
            // 
            this.keyViewBindingSource.DataSource = typeof(LynxPrivacyLib.KeyView);
            // 
            // Selected
            // 
            this.Selected.FalseValue = "false";
            this.Selected.HeaderText = "Selected";
            this.Selected.IndeterminateValue = "false";
            this.Selected.Name = "Selected";
            this.Selected.TrueValue = "true";
            this.Selected.Width = 60;
            // 
            // keyUserIdDataGridViewTextBoxColumn1
            // 
            this.keyUserIdDataGridViewTextBoxColumn1.DataPropertyName = "KeyUserId";
            this.keyUserIdDataGridViewTextBoxColumn1.HeaderText = "KeyUserId";
            this.keyUserIdDataGridViewTextBoxColumn1.Name = "keyUserIdDataGridViewTextBoxColumn1";
            this.keyUserIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // keyStoreIdDataGridViewTextBoxColumn1
            // 
            this.keyStoreIdDataGridViewTextBoxColumn1.DataPropertyName = "KeyStoreId";
            this.keyStoreIdDataGridViewTextBoxColumn1.HeaderText = "KeyStoreId";
            this.keyStoreIdDataGridViewTextBoxColumn1.Name = "keyStoreIdDataGridViewTextBoxColumn1";
            this.keyStoreIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            this.userNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // encryptionTypeDataGridViewTextBoxColumn1
            // 
            this.encryptionTypeDataGridViewTextBoxColumn1.DataPropertyName = "EncryptionType";
            this.encryptionTypeDataGridViewTextBoxColumn1.HeaderText = "EncryptionType";
            this.encryptionTypeDataGridViewTextBoxColumn1.Name = "encryptionTypeDataGridViewTextBoxColumn1";
            this.encryptionTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // keySizeDataGridViewTextBoxColumn1
            // 
            this.keySizeDataGridViewTextBoxColumn1.DataPropertyName = "KeySize";
            this.keySizeDataGridViewTextBoxColumn1.HeaderText = "KeySize";
            this.keySizeDataGridViewTextBoxColumn1.Name = "keySizeDataGridViewTextBoxColumn1";
            this.keySizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // creationTimeDataGridViewTextBoxColumn1
            // 
            this.creationTimeDataGridViewTextBoxColumn1.DataPropertyName = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn1.HeaderText = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn1.Name = "creationTimeDataGridViewTextBoxColumn1";
            this.creationTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // validDaysDataGridViewTextBoxColumn1
            // 
            this.validDaysDataGridViewTextBoxColumn1.DataPropertyName = "ValidDays";
            this.validDaysDataGridViewTextBoxColumn1.HeaderText = "ValidDays";
            this.validDaysDataGridViewTextBoxColumn1.Name = "validDaysDataGridViewTextBoxColumn1";
            this.validDaysDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isMasterKeyDataGridViewCheckBoxColumn1
            // 
            this.isMasterKeyDataGridViewCheckBoxColumn1.DataPropertyName = "IsMasterKey";
            this.isMasterKeyDataGridViewCheckBoxColumn1.HeaderText = "IsMasterKey";
            this.isMasterKeyDataGridViewCheckBoxColumn1.Name = "isMasterKeyDataGridViewCheckBoxColumn1";
            this.isMasterKeyDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // isSigningKeyDataGridViewCheckBoxColumn1
            // 
            this.isSigningKeyDataGridViewCheckBoxColumn1.DataPropertyName = "IsSigningKey";
            this.isSigningKeyDataGridViewCheckBoxColumn1.HeaderText = "IsSigningKey";
            this.isSigningKeyDataGridViewCheckBoxColumn1.Name = "isSigningKeyDataGridViewCheckBoxColumn1";
            this.isSigningKeyDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // isEncryptionKeyDataGridViewCheckBoxColumn1
            // 
            this.isEncryptionKeyDataGridViewCheckBoxColumn1.DataPropertyName = "IsEncryptionKey";
            this.isEncryptionKeyDataGridViewCheckBoxColumn1.HeaderText = "IsEncryptionKey";
            this.isEncryptionKeyDataGridViewCheckBoxColumn1.Name = "isEncryptionKeyDataGridViewCheckBoxColumn1";
            this.isEncryptionKeyDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // fingerprintDataGridViewTextBoxColumn1
            // 
            this.fingerprintDataGridViewTextBoxColumn1.DataPropertyName = "Fingerprint";
            this.fingerprintDataGridViewTextBoxColumn1.HeaderText = "Fingerprint";
            this.fingerprintDataGridViewTextBoxColumn1.Name = "fingerprintDataGridViewTextBoxColumn1";
            this.fingerprintDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ownerTrustDataGridViewTextBoxColumn1
            // 
            this.ownerTrustDataGridViewTextBoxColumn1.DataPropertyName = "OwnerTrust";
            this.ownerTrustDataGridViewTextBoxColumn1.HeaderText = "OwnerTrust";
            this.ownerTrustDataGridViewTextBoxColumn1.Name = "ownerTrustDataGridViewTextBoxColumn1";
            this.ownerTrustDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // keyTypeDataGridViewTextBoxColumn1
            // 
            this.keyTypeDataGridViewTextBoxColumn1.DataPropertyName = "KeyType";
            this.keyTypeDataGridViewTextBoxColumn1.HeaderText = "KeyType";
            this.keyTypeDataGridViewTextBoxColumn1.Name = "keyTypeDataGridViewTextBoxColumn1";
            this.keyTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Selected1
            // 
            this.Selected1.FalseValue = "false";
            this.Selected1.HeaderText = "Selected";
            this.Selected1.IndeterminateValue = "false";
            this.Selected1.Name = "Selected1";
            this.Selected1.TrueValue = "true";
            this.Selected1.Width = 60;
            // 
            // keyUserIdDataGridViewTextBoxColumn
            // 
            this.keyUserIdDataGridViewTextBoxColumn.DataPropertyName = "KeyUserId";
            this.keyUserIdDataGridViewTextBoxColumn.HeaderText = "KeyUserId";
            this.keyUserIdDataGridViewTextBoxColumn.Name = "keyUserIdDataGridViewTextBoxColumn";
            this.keyUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyStoreIdDataGridViewTextBoxColumn
            // 
            this.keyStoreIdDataGridViewTextBoxColumn.DataPropertyName = "KeyStoreId";
            this.keyStoreIdDataGridViewTextBoxColumn.HeaderText = "KeyStoreId";
            this.keyStoreIdDataGridViewTextBoxColumn.Name = "keyStoreIdDataGridViewTextBoxColumn";
            this.keyStoreIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encryptionTypeDataGridViewTextBoxColumn
            // 
            this.encryptionTypeDataGridViewTextBoxColumn.DataPropertyName = "EncryptionType";
            this.encryptionTypeDataGridViewTextBoxColumn.HeaderText = "EncryptionType";
            this.encryptionTypeDataGridViewTextBoxColumn.Name = "encryptionTypeDataGridViewTextBoxColumn";
            this.encryptionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keySizeDataGridViewTextBoxColumn
            // 
            this.keySizeDataGridViewTextBoxColumn.DataPropertyName = "KeySize";
            this.keySizeDataGridViewTextBoxColumn.HeaderText = "KeySize";
            this.keySizeDataGridViewTextBoxColumn.Name = "keySizeDataGridViewTextBoxColumn";
            this.keySizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationTimeDataGridViewTextBoxColumn
            // 
            this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.HeaderText = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
            this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validDaysDataGridViewTextBoxColumn
            // 
            this.validDaysDataGridViewTextBoxColumn.DataPropertyName = "ValidDays";
            this.validDaysDataGridViewTextBoxColumn.HeaderText = "ValidDays";
            this.validDaysDataGridViewTextBoxColumn.Name = "validDaysDataGridViewTextBoxColumn";
            this.validDaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isMasterKeyDataGridViewCheckBoxColumn
            // 
            this.isMasterKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsMasterKey";
            this.isMasterKeyDataGridViewCheckBoxColumn.HeaderText = "IsMasterKey";
            this.isMasterKeyDataGridViewCheckBoxColumn.Name = "isMasterKeyDataGridViewCheckBoxColumn";
            this.isMasterKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isSigningKeyDataGridViewCheckBoxColumn
            // 
            this.isSigningKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsSigningKey";
            this.isSigningKeyDataGridViewCheckBoxColumn.HeaderText = "IsSigningKey";
            this.isSigningKeyDataGridViewCheckBoxColumn.Name = "isSigningKeyDataGridViewCheckBoxColumn";
            this.isSigningKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isEncryptionKeyDataGridViewCheckBoxColumn
            // 
            this.isEncryptionKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsEncryptionKey";
            this.isEncryptionKeyDataGridViewCheckBoxColumn.HeaderText = "IsEncryptionKey";
            this.isEncryptionKeyDataGridViewCheckBoxColumn.Name = "isEncryptionKeyDataGridViewCheckBoxColumn";
            this.isEncryptionKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fingerprintDataGridViewTextBoxColumn
            // 
            this.fingerprintDataGridViewTextBoxColumn.DataPropertyName = "Fingerprint";
            this.fingerprintDataGridViewTextBoxColumn.HeaderText = "Fingerprint";
            this.fingerprintDataGridViewTextBoxColumn.Name = "fingerprintDataGridViewTextBoxColumn";
            this.fingerprintDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerTrustDataGridViewTextBoxColumn
            // 
            this.ownerTrustDataGridViewTextBoxColumn.DataPropertyName = "OwnerTrust";
            this.ownerTrustDataGridViewTextBoxColumn.HeaderText = "OwnerTrust";
            this.ownerTrustDataGridViewTextBoxColumn.Name = "ownerTrustDataGridViewTextBoxColumn";
            this.ownerTrustDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyTypeDataGridViewTextBoxColumn
            // 
            this.keyTypeDataGridViewTextBoxColumn.DataPropertyName = "KeyType";
            this.keyTypeDataGridViewTextBoxColumn.HeaderText = "KeyType";
            this.keyTypeDataGridViewTextBoxColumn.Name = "keyTypeDataGridViewTextBoxColumn";
            this.keyTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EncryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 404);
            this.Controls.Add(this.btnEncryptSign);
            this.Controls.Add(this.btnEncryptOnly);
            this.Controls.Add(this.btnSignOnly);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.lblSaveFile);
            this.Controls.Add(this.lblSelectSender);
            this.Controls.Add(this.lblChoosePublicKeys);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvPublicKeys);
            this.Controls.Add(this.btnPubKeyFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPubKeyFilter);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtChooseFile);
            this.Controls.Add(this.lblChooseFile);
            this.Name = "EncryptFile";
            this.Text = "EncryptFile";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblChooseFile;
        private System.Windows.Forms.TextBox txtChooseFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnPubKeyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubKeyFilter;
        private System.Windows.Forms.DataGridView dgvPublicKeys;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblChoosePublicKeys;
        private System.Windows.Forms.Label lblSelectSender;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Label lblSaveFile;
        private System.Windows.Forms.Button btnSignOnly;
        private System.Windows.Forms.Button btnEncryptOnly;
        private System.Windows.Forms.Button btnEncryptSign;
        private System.Windows.Forms.BindingSource keyViewBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyUserIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyStoreIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn encryptionTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keySizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDaysDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMasterKeyDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSigningKeyDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEncryptionKeyDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerprintDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerTrustDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyStoreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encryptionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keySizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMasterKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSigningKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEncryptionKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerprintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerTrustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyTypeDataGridViewTextBoxColumn;
    }
}