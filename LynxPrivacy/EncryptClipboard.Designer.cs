﻿namespace LynxPrivacy
{
    partial class EncryptClipboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptClipboard));
            this.btnEncryptSign = new System.Windows.Forms.Button();
            this.btnEncryptOnly = new System.Windows.Forms.Button();
            this.btnSignOnly = new System.Windows.Forms.Button();
            this.lblSelectSender = new System.Windows.Forms.Label();
            this.lblChoosePublicKeys = new System.Windows.Forms.Label();
            this.dgvSecretKeys = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvPublicKeys = new System.Windows.Forms.DataGridView();
            this.Selected1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPubKeyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubKeyFilter = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDisplayClipBrd = new System.Windows.Forms.Button();
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
            this.keyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncryptSign
            // 
            this.btnEncryptSign.Location = new System.Drawing.Point(223, 376);
            this.btnEncryptSign.Name = "btnEncryptSign";
            this.btnEncryptSign.Size = new System.Drawing.Size(108, 25);
            this.btnEncryptSign.TabIndex = 31;
            this.btnEncryptSign.Text = "Encrypt and Sign";
            this.btnEncryptSign.UseVisualStyleBackColor = true;
            this.btnEncryptSign.Click += new System.EventHandler(this.btnEncryptSign_Click);
            // 
            // btnEncryptOnly
            // 
            this.btnEncryptOnly.Location = new System.Drawing.Point(121, 376);
            this.btnEncryptOnly.Name = "btnEncryptOnly";
            this.btnEncryptOnly.Size = new System.Drawing.Size(78, 25);
            this.btnEncryptOnly.TabIndex = 30;
            this.btnEncryptOnly.Text = "Encrypt Only";
            this.btnEncryptOnly.UseVisualStyleBackColor = true;
            this.btnEncryptOnly.Click += new System.EventHandler(this.btnEncryptOnly_Click);
            // 
            // btnSignOnly
            // 
            this.btnSignOnly.Location = new System.Drawing.Point(26, 376);
            this.btnSignOnly.Name = "btnSignOnly";
            this.btnSignOnly.Size = new System.Drawing.Size(78, 25);
            this.btnSignOnly.TabIndex = 29;
            this.btnSignOnly.Text = "Sign Only";
            this.btnSignOnly.UseVisualStyleBackColor = true;
            this.btnSignOnly.Click += new System.EventHandler(this.btnSignOnly_Click);
            // 
            // lblSelectSender
            // 
            this.lblSelectSender.AutoSize = true;
            this.lblSelectSender.Location = new System.Drawing.Point(22, 258);
            this.lblSelectSender.Name = "lblSelectSender";
            this.lblSelectSender.Size = new System.Drawing.Size(74, 13);
            this.lblSelectSender.TabIndex = 28;
            this.lblSelectSender.Text = "Select Sender";
            // 
            // lblChoosePublicKeys
            // 
            this.lblChoosePublicKeys.AutoSize = true;
            this.lblChoosePublicKeys.Location = new System.Drawing.Point(15, 107);
            this.lblChoosePublicKeys.Name = "lblChoosePublicKeys";
            this.lblChoosePublicKeys.Size = new System.Drawing.Size(90, 13);
            this.lblChoosePublicKeys.TabIndex = 27;
            this.lblChoosePublicKeys.Text = "Select Recipients";
            // 
            // dgvSecretKeys
            // 
            this.dgvSecretKeys.AllowUserToAddRows = false;
            this.dgvSecretKeys.AllowUserToDeleteRows = false;
            this.dgvSecretKeys.AutoGenerateColumns = false;
            this.dgvSecretKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecretKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
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
            this.dgvSecretKeys.DataSource = this.keyViewBindingSource;
            this.dgvSecretKeys.Location = new System.Drawing.Point(9, 277);
            this.dgvSecretKeys.Name = "dgvSecretKeys";
            this.dgvSecretKeys.ReadOnly = true;
            this.dgvSecretKeys.Size = new System.Drawing.Size(724, 78);
            this.dgvSecretKeys.TabIndex = 26;
            this.dgvSecretKeys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecretKeys_CellClick);
            this.dgvSecretKeys.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSecretKeys_ColumnHeaderMouseClick);
            this.dgvSecretKeys.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSecretKeys_DataBindingComplete);
            // 
            // Selected
            // 
            this.Selected.FalseValue = "false";
            this.Selected.HeaderText = "Selected";
            this.Selected.IndeterminateValue = "false";
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.TrueValue = "true";
            this.Selected.Width = 60;
            // 
            // dgvPublicKeys
            // 
            this.dgvPublicKeys.AllowUserToAddRows = false;
            this.dgvPublicKeys.AllowUserToDeleteRows = false;
            this.dgvPublicKeys.AutoGenerateColumns = false;
            this.dgvPublicKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected1,
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
            this.dgvPublicKeys.DataSource = this.keyViewBindingSource;
            this.dgvPublicKeys.Location = new System.Drawing.Point(9, 129);
            this.dgvPublicKeys.Name = "dgvPublicKeys";
            this.dgvPublicKeys.ReadOnly = true;
            this.dgvPublicKeys.Size = new System.Drawing.Size(724, 110);
            this.dgvPublicKeys.TabIndex = 25;
            this.dgvPublicKeys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublicKeys_CellClick);
            this.dgvPublicKeys.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPublicKeys_ColumnHeaderMouseClick);
            this.dgvPublicKeys.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPublicKeys_DataBindingComplete);
            // 
            // Selected1
            // 
            this.Selected1.FalseValue = "false";
            this.Selected1.HeaderText = "Selected";
            this.Selected1.IndeterminateValue = "false";
            this.Selected1.Name = "Selected1";
            this.Selected1.ReadOnly = true;
            this.Selected1.TrueValue = "true";
            this.Selected1.Width = 60;
            // 
            // btnPubKeyFilter
            // 
            this.btnPubKeyFilter.Location = new System.Drawing.Point(358, 100);
            this.btnPubKeyFilter.Name = "btnPubKeyFilter";
            this.btnPubKeyFilter.Size = new System.Drawing.Size(86, 23);
            this.btnPubKeyFilter.TabIndex = 24;
            this.btnPubKeyFilter.Text = "Filter";
            this.btnPubKeyFilter.UseVisualStyleBackColor = true;
            this.btnPubKeyFilter.Click += new System.EventHandler(this.btnPubKeyFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter Filter:";
            // 
            // txtPubKeyFilter
            // 
            this.txtPubKeyFilter.Location = new System.Drawing.Point(223, 100);
            this.txtPubKeyFilter.Name = "txtPubKeyFilter";
            this.txtPubKeyFilter.Size = new System.Drawing.Size(117, 20);
            this.txtPubKeyFilter.TabIndex = 22;
            this.txtPubKeyFilter.Tag = "Enter Filter Data";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(733, 63);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btnDisplayClipBrd
            // 
            this.btnDisplayClipBrd.Location = new System.Drawing.Point(19, 9);
            this.btnDisplayClipBrd.Name = "btnDisplayClipBrd";
            this.btnDisplayClipBrd.Size = new System.Drawing.Size(104, 23);
            this.btnDisplayClipBrd.TabIndex = 33;
            this.btnDisplayClipBrd.Text = "Show Clipboard";
            this.btnDisplayClipBrd.UseVisualStyleBackColor = true;
            this.btnDisplayClipBrd.Click += new System.EventHandler(this.btnDisplayClipBrd_Click);
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
            // keyViewBindingSource
            // 
            this.keyViewBindingSource.DataSource = typeof(LynxPrivacyLib.KeyView);
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
            // EncryptClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 423);
            this.Controls.Add(this.btnDisplayClipBrd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnEncryptSign);
            this.Controls.Add(this.btnEncryptOnly);
            this.Controls.Add(this.btnSignOnly);
            this.Controls.Add(this.lblSelectSender);
            this.Controls.Add(this.lblChoosePublicKeys);
            this.Controls.Add(this.dgvSecretKeys);
            this.Controls.Add(this.dgvPublicKeys);
            this.Controls.Add(this.btnPubKeyFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPubKeyFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptClipboard";
            this.Text = "EncryptClipboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncryptClipboard_FormClosing);
            this.Load += new System.EventHandler(this.EncryptClipboard_Load);
            this.Resize += new System.EventHandler(this.EncryptClipboard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncryptSign;
        private System.Windows.Forms.Button btnEncryptOnly;
        private System.Windows.Forms.Button btnSignOnly;
        private System.Windows.Forms.Label lblSelectSender;
        private System.Windows.Forms.Label lblChoosePublicKeys;
        private System.Windows.Forms.DataGridView dgvSecretKeys;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridView dgvPublicKeys;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected1;
        private System.Windows.Forms.Button btnPubKeyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubKeyFilter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDisplayClipBrd;
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
        private System.Windows.Forms.BindingSource keyViewBindingSource;
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
    }
}