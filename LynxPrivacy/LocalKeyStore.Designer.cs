namespace LynxPrivacy
{
    partial class LocalKeyStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalKeyStore));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPublic = new System.Windows.Forms.TabPage();
            this.btnPubKeyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubKeyFilter = new System.Windows.Forms.TextBox();
            this.btnSetLocalTrust = new System.Windows.Forms.Button();
            this.btnExportKey = new System.Windows.Forms.Button();
            this.btnUploadToKeyserver = new System.Windows.Forms.Button();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.btnRefreshFromKeyserver = new System.Windows.Forms.Button();
            this.dgvPublicKeys = new System.Windows.Forms.DataGridView();
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
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.btnSecSetLocalTrust = new System.Windows.Forms.Button();
            this.btnExpireKey = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnChangePassphrase = new System.Windows.Forms.Button();
            this.btnExportSecKey = new System.Windows.Forms.Button();
            this.btnSecKeyFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecKeyfilter = new System.Windows.Forms.TextBox();
            this.dgvSecretKeys = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExportKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUploadKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetLocalTrust = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPublic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).BeginInit();
            this.tabSecret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretKeys)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPublic);
            this.tabControl1.Controls.Add(this.tabSecret);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 533);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPublic
            // 
            this.tabPublic.Controls.Add(this.btnPubKeyFilter);
            this.tabPublic.Controls.Add(this.label1);
            this.tabPublic.Controls.Add(this.txtPubKeyFilter);
            this.tabPublic.Controls.Add(this.btnSetLocalTrust);
            this.tabPublic.Controls.Add(this.btnExportKey);
            this.tabPublic.Controls.Add(this.btnUploadToKeyserver);
            this.tabPublic.Controls.Add(this.btnImportKey);
            this.tabPublic.Controls.Add(this.btnRefreshFromKeyserver);
            this.tabPublic.Controls.Add(this.dgvPublicKeys);
            this.tabPublic.Location = new System.Drawing.Point(4, 22);
            this.tabPublic.Name = "tabPublic";
            this.tabPublic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublic.Size = new System.Drawing.Size(860, 507);
            this.tabPublic.TabIndex = 0;
            this.tabPublic.Text = "Public Keys";
            this.tabPublic.UseVisualStyleBackColor = true;
            // 
            // btnPubKeyFilter
            // 
            this.btnPubKeyFilter.Location = new System.Drawing.Point(242, 76);
            this.btnPubKeyFilter.Name = "btnPubKeyFilter";
            this.btnPubKeyFilter.Size = new System.Drawing.Size(86, 23);
            this.btnPubKeyFilter.TabIndex = 8;
            this.btnPubKeyFilter.Text = "Filter";
            this.btnPubKeyFilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Filter:";
            // 
            // txtPubKeyFilter
            // 
            this.txtPubKeyFilter.Location = new System.Drawing.Point(107, 76);
            this.txtPubKeyFilter.Name = "txtPubKeyFilter";
            this.txtPubKeyFilter.Size = new System.Drawing.Size(117, 20);
            this.txtPubKeyFilter.TabIndex = 6;
            this.txtPubKeyFilter.Tag = "Enter Filter Data";
            // 
            // btnSetLocalTrust
            // 
            this.btnSetLocalTrust.Location = new System.Drawing.Point(539, 21);
            this.btnSetLocalTrust.Name = "btnSetLocalTrust";
            this.btnSetLocalTrust.Size = new System.Drawing.Size(98, 23);
            this.btnSetLocalTrust.TabIndex = 5;
            this.btnSetLocalTrust.Text = "Set Local Trust";
            this.btnSetLocalTrust.UseVisualStyleBackColor = true;
            // 
            // btnExportKey
            // 
            this.btnExportKey.Location = new System.Drawing.Point(449, 21);
            this.btnExportKey.Name = "btnExportKey";
            this.btnExportKey.Size = new System.Drawing.Size(84, 23);
            this.btnExportKey.TabIndex = 4;
            this.btnExportKey.Text = "Export Key";
            this.btnExportKey.UseVisualStyleBackColor = true;
            this.btnExportKey.Click += new System.EventHandler(this.btnExportKey_Click);
            // 
            // btnUploadToKeyserver
            // 
            this.btnUploadToKeyserver.Location = new System.Drawing.Point(303, 21);
            this.btnUploadToKeyserver.Name = "btnUploadToKeyserver";
            this.btnUploadToKeyserver.Size = new System.Drawing.Size(140, 23);
            this.btnUploadToKeyserver.TabIndex = 3;
            this.btnUploadToKeyserver.Text = "Upload Key to Keyserver";
            this.btnUploadToKeyserver.UseVisualStyleBackColor = true;
            this.btnUploadToKeyserver.Click += new System.EventHandler(this.btnUploadToKeyserver_Click);
            // 
            // btnImportKey
            // 
            this.btnImportKey.Location = new System.Drawing.Point(231, 21);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(66, 23);
            this.btnImportKey.TabIndex = 2;
            this.btnImportKey.Text = "Import Key";
            this.btnImportKey.UseVisualStyleBackColor = true;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            // 
            // btnRefreshFromKeyserver
            // 
            this.btnRefreshFromKeyserver.Location = new System.Drawing.Point(24, 21);
            this.btnRefreshFromKeyserver.Name = "btnRefreshFromKeyserver";
            this.btnRefreshFromKeyserver.Size = new System.Drawing.Size(201, 23);
            this.btnRefreshFromKeyserver.TabIndex = 1;
            this.btnRefreshFromKeyserver.Text = "Refresh Public Keys from Key Server";
            this.btnRefreshFromKeyserver.UseVisualStyleBackColor = true;
            this.btnRefreshFromKeyserver.Click += new System.EventHandler(this.btnRefreshFromKeyserver_Click);
            // 
            // dgvPublicKeys
            // 
            this.dgvPublicKeys.AllowUserToAddRows = false;
            this.dgvPublicKeys.AllowUserToDeleteRows = false;
            this.dgvPublicKeys.AutoGenerateColumns = false;
            this.dgvPublicKeys.ColumnHeadersHeight = 22;
            this.dgvPublicKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvPublicKeys.Location = new System.Drawing.Point(3, 111);
            this.dgvPublicKeys.Name = "dgvPublicKeys";
            this.dgvPublicKeys.ReadOnly = true;
            this.dgvPublicKeys.Size = new System.Drawing.Size(851, 393);
            this.dgvPublicKeys.TabIndex = 0;
            this.dgvPublicKeys.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPublicKeys_ColumnHeaderMouseClick);
            this.dgvPublicKeys.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPublicKeys_DataBindingComplete);
            this.dgvPublicKeys.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvPublicKeys_RowContextMenuStripNeeded);
            // 
            // keyUserIdDataGridViewTextBoxColumn
            // 
            this.keyUserIdDataGridViewTextBoxColumn.DataPropertyName = "KeyUserId";
            this.keyUserIdDataGridViewTextBoxColumn.HeaderText = "KeyUserId";
            this.keyUserIdDataGridViewTextBoxColumn.Name = "keyUserIdDataGridViewTextBoxColumn";
            this.keyUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // keyStoreIdDataGridViewTextBoxColumn
            // 
            this.keyStoreIdDataGridViewTextBoxColumn.DataPropertyName = "KeyStoreId";
            this.keyStoreIdDataGridViewTextBoxColumn.HeaderText = "KeyStoreId";
            this.keyStoreIdDataGridViewTextBoxColumn.Name = "keyStoreIdDataGridViewTextBoxColumn";
            this.keyStoreIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyStoreIdDataGridViewTextBoxColumn.Visible = false;
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
            this.emailDataGridViewTextBoxColumn.Width = 140;
            // 
            // encryptionTypeDataGridViewTextBoxColumn
            // 
            this.encryptionTypeDataGridViewTextBoxColumn.DataPropertyName = "EncryptionType";
            this.encryptionTypeDataGridViewTextBoxColumn.HeaderText = "EncryptionType";
            this.encryptionTypeDataGridViewTextBoxColumn.Name = "encryptionTypeDataGridViewTextBoxColumn";
            this.encryptionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.encryptionTypeDataGridViewTextBoxColumn.Width = 70;
            // 
            // keySizeDataGridViewTextBoxColumn
            // 
            this.keySizeDataGridViewTextBoxColumn.DataPropertyName = "KeySize";
            this.keySizeDataGridViewTextBoxColumn.HeaderText = "KeySize";
            this.keySizeDataGridViewTextBoxColumn.Name = "keySizeDataGridViewTextBoxColumn";
            this.keySizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.keySizeDataGridViewTextBoxColumn.Width = 50;
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
            this.validDaysDataGridViewTextBoxColumn.Width = 54;
            // 
            // isMasterKeyDataGridViewCheckBoxColumn
            // 
            this.isMasterKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsMasterKey";
            this.isMasterKeyDataGridViewCheckBoxColumn.HeaderText = "IsMasterKey";
            this.isMasterKeyDataGridViewCheckBoxColumn.Name = "isMasterKeyDataGridViewCheckBoxColumn";
            this.isMasterKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isMasterKeyDataGridViewCheckBoxColumn.Width = 70;
            // 
            // isSigningKeyDataGridViewCheckBoxColumn
            // 
            this.isSigningKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsSigningKey";
            this.isSigningKeyDataGridViewCheckBoxColumn.HeaderText = "IsSigningKey";
            this.isSigningKeyDataGridViewCheckBoxColumn.Name = "isSigningKeyDataGridViewCheckBoxColumn";
            this.isSigningKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isSigningKeyDataGridViewCheckBoxColumn.Width = 74;
            // 
            // isEncryptionKeyDataGridViewCheckBoxColumn
            // 
            this.isEncryptionKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsEncryptionKey";
            this.isEncryptionKeyDataGridViewCheckBoxColumn.HeaderText = "IsEncryptionKey";
            this.isEncryptionKeyDataGridViewCheckBoxColumn.Name = "isEncryptionKeyDataGridViewCheckBoxColumn";
            this.isEncryptionKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isEncryptionKeyDataGridViewCheckBoxColumn.Width = 84;
            // 
            // fingerprintDataGridViewTextBoxColumn
            // 
            this.fingerprintDataGridViewTextBoxColumn.DataPropertyName = "Fingerprint";
            this.fingerprintDataGridViewTextBoxColumn.HeaderText = "Fingerprint";
            this.fingerprintDataGridViewTextBoxColumn.Name = "fingerprintDataGridViewTextBoxColumn";
            this.fingerprintDataGridViewTextBoxColumn.ReadOnly = true;
            this.fingerprintDataGridViewTextBoxColumn.Width = 300;
            // 
            // ownerTrustDataGridViewTextBoxColumn
            // 
            this.ownerTrustDataGridViewTextBoxColumn.DataPropertyName = "OwnerTrust";
            this.ownerTrustDataGridViewTextBoxColumn.HeaderText = "OwnerTrust";
            this.ownerTrustDataGridViewTextBoxColumn.Name = "ownerTrustDataGridViewTextBoxColumn";
            this.ownerTrustDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerTrustDataGridViewTextBoxColumn.Width = 68;
            // 
            // keyTypeDataGridViewTextBoxColumn
            // 
            this.keyTypeDataGridViewTextBoxColumn.DataPropertyName = "KeyType";
            this.keyTypeDataGridViewTextBoxColumn.HeaderText = "KeyType";
            this.keyTypeDataGridViewTextBoxColumn.Name = "keyTypeDataGridViewTextBoxColumn";
            this.keyTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyTypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // keyViewBindingSource
            // 
            this.keyViewBindingSource.DataSource = typeof(LynxPrivacyLib.KeyView);
            // 
            // tabSecret
            // 
            this.tabSecret.Controls.Add(this.btnSecSetLocalTrust);
            this.tabSecret.Controls.Add(this.btnExpireKey);
            this.tabSecret.Controls.Add(this.btnRevoke);
            this.tabSecret.Controls.Add(this.btnChangePassphrase);
            this.tabSecret.Controls.Add(this.btnExportSecKey);
            this.tabSecret.Controls.Add(this.btnSecKeyFilter);
            this.tabSecret.Controls.Add(this.label2);
            this.tabSecret.Controls.Add(this.txtSecKeyfilter);
            this.tabSecret.Controls.Add(this.dgvSecretKeys);
            this.tabSecret.Location = new System.Drawing.Point(4, 22);
            this.tabSecret.Name = "tabSecret";
            this.tabSecret.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecret.Size = new System.Drawing.Size(860, 507);
            this.tabSecret.TabIndex = 1;
            this.tabSecret.Text = "Secret Keys";
            this.tabSecret.UseVisualStyleBackColor = true;
            // 
            // btnSecSetLocalTrust
            // 
            this.btnSecSetLocalTrust.Location = new System.Drawing.Point(420, 16);
            this.btnSecSetLocalTrust.Name = "btnSecSetLocalTrust";
            this.btnSecSetLocalTrust.Size = new System.Drawing.Size(90, 23);
            this.btnSecSetLocalTrust.TabIndex = 16;
            this.btnSecSetLocalTrust.Text = "Set Local Trust";
            this.btnSecSetLocalTrust.UseVisualStyleBackColor = true;
            this.btnSecSetLocalTrust.Click += new System.EventHandler(this.btnSecSetLocalTrust_Click);
            // 
            // btnExpireKey
            // 
            this.btnExpireKey.Location = new System.Drawing.Point(339, 16);
            this.btnExpireKey.Name = "btnExpireKey";
            this.btnExpireKey.Size = new System.Drawing.Size(75, 23);
            this.btnExpireKey.TabIndex = 15;
            this.btnExpireKey.Text = "Expire Key";
            this.btnExpireKey.UseVisualStyleBackColor = true;
            this.btnExpireKey.Click += new System.EventHandler(this.btnExpireKey_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(258, 16);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(75, 23);
            this.btnRevoke.TabIndex = 14;
            this.btnRevoke.Text = "Revoke Key";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnChangePassphrase
            // 
            this.btnChangePassphrase.Location = new System.Drawing.Point(121, 16);
            this.btnChangePassphrase.Name = "btnChangePassphrase";
            this.btnChangePassphrase.Size = new System.Drawing.Size(131, 23);
            this.btnChangePassphrase.TabIndex = 13;
            this.btnChangePassphrase.Text = "Change Pass Phrase";
            this.btnChangePassphrase.UseVisualStyleBackColor = true;
            this.btnChangePassphrase.Click += new System.EventHandler(this.btnChangePassphrase_Click);
            // 
            // btnExportSecKey
            // 
            this.btnExportSecKey.Location = new System.Drawing.Point(40, 16);
            this.btnExportSecKey.Name = "btnExportSecKey";
            this.btnExportSecKey.Size = new System.Drawing.Size(75, 23);
            this.btnExportSecKey.TabIndex = 12;
            this.btnExportSecKey.Text = "Export Key";
            this.btnExportSecKey.UseVisualStyleBackColor = true;
            this.btnExportSecKey.Click += new System.EventHandler(this.btnExportSecKey_Click);
            // 
            // btnSecKeyFilter
            // 
            this.btnSecKeyFilter.Location = new System.Drawing.Point(235, 73);
            this.btnSecKeyFilter.Name = "btnSecKeyFilter";
            this.btnSecKeyFilter.Size = new System.Drawing.Size(86, 23);
            this.btnSecKeyFilter.TabIndex = 11;
            this.btnSecKeyFilter.Text = "Filter";
            this.btnSecKeyFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Filter:";
            // 
            // txtSecKeyfilter
            // 
            this.txtSecKeyfilter.Location = new System.Drawing.Point(100, 73);
            this.txtSecKeyfilter.Name = "txtSecKeyfilter";
            this.txtSecKeyfilter.Size = new System.Drawing.Size(117, 20);
            this.txtSecKeyfilter.TabIndex = 9;
            this.txtSecKeyfilter.Tag = "Enter Filter Data";
            // 
            // dgvSecretKeys
            // 
            this.dgvSecretKeys.AllowUserToAddRows = false;
            this.dgvSecretKeys.AllowUserToDeleteRows = false;
            this.dgvSecretKeys.AutoGenerateColumns = false;
            this.dgvSecretKeys.ColumnHeadersHeight = 22;
            this.dgvSecretKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.DefaultKey,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvSecretKeys.DataSource = this.keyViewBindingSource;
            this.dgvSecretKeys.Location = new System.Drawing.Point(6, 108);
            this.dgvSecretKeys.Name = "dgvSecretKeys";
            this.dgvSecretKeys.ReadOnly = true;
            this.dgvSecretKeys.Size = new System.Drawing.Size(851, 393);
            this.dgvSecretKeys.TabIndex = 1;
            this.dgvSecretKeys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecretKeys_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KeyUserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "KeyUserId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KeyStoreId";
            this.dataGridViewTextBoxColumn2.HeaderText = "KeyStoreId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // DefaultKey
            // 
            this.DefaultKey.HeaderText = "DefaultKey";
            this.DefaultKey.Name = "DefaultKey";
            this.DefaultKey.ReadOnly = true;
            this.DefaultKey.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EncryptionType";
            this.dataGridViewTextBoxColumn5.HeaderText = "EncryptionType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KeySize";
            this.dataGridViewTextBoxColumn6.HeaderText = "KeySize";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreationTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "CreationTime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValidDays";
            this.dataGridViewTextBoxColumn8.HeaderText = "ValidDays";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 54;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsMasterKey";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsMasterKey";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsSigningKey";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsSigningKey";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 74;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsEncryptionKey";
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsEncryptionKey";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 84;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fingerprint";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fingerprint";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 300;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OwnerTrust";
            this.dataGridViewTextBoxColumn10.HeaderText = "OwnerTrust";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 68;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "KeyType";
            this.dataGridViewTextBoxColumn11.HeaderText = "KeyType";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportKey,
            this.tsmiUploadKey,
            this.tsmiSetLocalTrust});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 70);
            // 
            // tsmiExportKey
            // 
            this.tsmiExportKey.Name = "tsmiExportKey";
            this.tsmiExportKey.Size = new System.Drawing.Size(205, 22);
            this.tsmiExportKey.Text = "Export Key";
            // 
            // tsmiUploadKey
            // 
            this.tsmiUploadKey.Name = "tsmiUploadKey";
            this.tsmiUploadKey.Size = new System.Drawing.Size(205, 22);
            this.tsmiUploadKey.Text = "Upload Key to Key Server";
            // 
            // tsmiSetLocalTrust
            // 
            this.tsmiSetLocalTrust.Name = "tsmiSetLocalTrust";
            this.tsmiSetLocalTrust.Size = new System.Drawing.Size(205, 22);
            this.tsmiSetLocalTrust.Text = "Set Local Trust";
            // 
            // LocalKeyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 557);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalKeyStore";
            this.Text = "LocalKeyStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocalKeyStore_FormClosing);
            this.Load += new System.EventHandler(this.LocalKeyStore_Load);
            this.Resize += new System.EventHandler(this.LocalKeyStore_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPublic.ResumeLayout(false);
            this.tabPublic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).EndInit();
            this.tabSecret.ResumeLayout(false);
            this.tabSecret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretKeys)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPublic;
        private System.Windows.Forms.TabPage tabSecret;
        private System.Windows.Forms.DataGridView dgvPublicKeys;
        private System.Windows.Forms.BindingSource keyViewBindingSource;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportKey;
        private System.Windows.Forms.Button btnPubKeyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubKeyFilter;
        private System.Windows.Forms.Button btnSetLocalTrust;
        private System.Windows.Forms.Button btnExportKey;
        private System.Windows.Forms.Button btnUploadToKeyserver;
        private System.Windows.Forms.Button btnImportKey;
        private System.Windows.Forms.Button btnRefreshFromKeyserver;
        private System.Windows.Forms.ToolStripMenuItem tsmiUploadKey;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetLocalTrust;
        private System.Windows.Forms.DataGridView dgvSecretKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DefaultKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnSecKeyFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecKeyfilter;
        private System.Windows.Forms.Button btnSecSetLocalTrust;
        private System.Windows.Forms.Button btnExpireKey;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnChangePassphrase;
        private System.Windows.Forms.Button btnExportSecKey;
    }
}