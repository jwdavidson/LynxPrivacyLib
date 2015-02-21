namespace LynxPrivacy
{
    partial class frmLocalKeyStore
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPublic = new System.Windows.Forms.TabPage();
            this.tabSecret = new System.Windows.Forms.TabPage();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExportKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUploadKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetLocalTrust = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshFromKeyserver = new System.Windows.Forms.Button();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.btnUploadToKeyserver = new System.Windows.Forms.Button();
            this.btnExportKey = new System.Windows.Forms.Button();
            this.btnSetLocalTrust = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPublic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).BeginInit();
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
            // 
            // tabPublic
            // 
            this.tabPublic.Controls.Add(this.button1);
            this.tabPublic.Controls.Add(this.label1);
            this.tabPublic.Controls.Add(this.textBox1);
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
            // tabSecret
            // 
            this.tabSecret.Location = new System.Drawing.Point(4, 22);
            this.tabSecret.Name = "tabSecret";
            this.tabSecret.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecret.Size = new System.Drawing.Size(860, 507);
            this.tabSecret.TabIndex = 1;
            this.tabSecret.Text = "Secret Keys";
            this.tabSecret.UseVisualStyleBackColor = true;
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
            // btnRefreshFromKeyserver
            // 
            this.btnRefreshFromKeyserver.Location = new System.Drawing.Point(24, 21);
            this.btnRefreshFromKeyserver.Name = "btnRefreshFromKeyserver";
            this.btnRefreshFromKeyserver.Size = new System.Drawing.Size(201, 23);
            this.btnRefreshFromKeyserver.TabIndex = 1;
            this.btnRefreshFromKeyserver.Text = "Refresh Public Keys from Key Server";
            this.btnRefreshFromKeyserver.UseVisualStyleBackColor = true;
            // 
            // btnImportKey
            // 
            this.btnImportKey.Location = new System.Drawing.Point(231, 21);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(66, 23);
            this.btnImportKey.TabIndex = 2;
            this.btnImportKey.Text = "Import Key";
            this.btnImportKey.UseVisualStyleBackColor = true;
            // 
            // btnUploadToKeyserver
            // 
            this.btnUploadToKeyserver.Location = new System.Drawing.Point(303, 21);
            this.btnUploadToKeyserver.Name = "btnUploadToKeyserver";
            this.btnUploadToKeyserver.Size = new System.Drawing.Size(140, 23);
            this.btnUploadToKeyserver.TabIndex = 3;
            this.btnUploadToKeyserver.Text = "Upload Key to Keyserver";
            this.btnUploadToKeyserver.UseVisualStyleBackColor = true;
            // 
            // btnExportKey
            // 
            this.btnExportKey.Location = new System.Drawing.Point(449, 21);
            this.btnExportKey.Name = "btnExportKey";
            this.btnExportKey.Size = new System.Drawing.Size(84, 23);
            this.btnExportKey.TabIndex = 4;
            this.btnExportKey.Text = "Export Key";
            this.btnExportKey.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Tag = "Enter Filter Data";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLocalKeyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLocalKeyStore";
            this.Text = "LocalKeyStore";
            this.Load += new System.EventHandler(this.LocalKeyStore_Load);
            this.Resize += new System.EventHandler(this.frmLocalKeyStore_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPublic.ResumeLayout(false);
            this.tabPublic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyViewBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSetLocalTrust;
        private System.Windows.Forms.Button btnExportKey;
        private System.Windows.Forms.Button btnUploadToKeyserver;
        private System.Windows.Forms.Button btnImportKey;
        private System.Windows.Forms.Button btnRefreshFromKeyserver;
        private System.Windows.Forms.ToolStripMenuItem tsmiUploadKey;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetLocalTrust;
    }
}