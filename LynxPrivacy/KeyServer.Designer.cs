namespace LynxPrivacy
{
    partial class KeyServer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchKeyserver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubKeyFilter = new System.Windows.Forms.TextBox();
            this.btnLocalSearch = new System.Windows.Forms.Button();
            this.btmImportSelectedKeysToKeystore = new System.Windows.Forms.Button();
            this.keySearchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keyLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyCreatedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyExpiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keySizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySearchViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.keyLineDataGridViewTextBoxColumn,
            this.keyIdDataGridViewTextBoxColumn,
            this.uidStringDataGridViewTextBoxColumn,
            this.keyCreatedDateDataGridViewTextBoxColumn,
            this.keyExpiredDateDataGridViewTextBoxColumn,
            this.algorithmDataGridViewTextBoxColumn,
            this.keySizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.keySearchViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(907, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // btnSearchKeyserver
            // 
            this.btnSearchKeyserver.Location = new System.Drawing.Point(364, 62);
            this.btnSearchKeyserver.Name = "btnSearchKeyserver";
            this.btnSearchKeyserver.Size = new System.Drawing.Size(153, 23);
            this.btnSearchKeyserver.TabIndex = 11;
            this.btnSearchKeyserver.Text = "Search Remote Keyserver";
            this.btnSearchKeyserver.UseVisualStyleBackColor = true;
            this.btnSearchKeyserver.Click += new System.EventHandler(this.btnSearchKeyserver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Search Text:";
            // 
            // txtPubKeyFilter
            // 
            this.txtPubKeyFilter.Location = new System.Drawing.Point(124, 62);
            this.txtPubKeyFilter.Name = "txtPubKeyFilter";
            this.txtPubKeyFilter.Size = new System.Drawing.Size(234, 20);
            this.txtPubKeyFilter.TabIndex = 9;
            this.txtPubKeyFilter.Tag = "Enter Filter Data";
            // 
            // btnLocalSearch
            // 
            this.btnLocalSearch.Location = new System.Drawing.Point(523, 62);
            this.btnLocalSearch.Name = "btnLocalSearch";
            this.btnLocalSearch.Size = new System.Drawing.Size(180, 23);
            this.btnLocalSearch.TabIndex = 12;
            this.btnLocalSearch.Text = "Search Local Keyserver Results";
            this.btnLocalSearch.UseVisualStyleBackColor = true;
            this.btnLocalSearch.Click += new System.EventHandler(this.btnLocalSearch_Click);
            // 
            // btmImportSelectedKeysToKeystore
            // 
            this.btmImportSelectedKeysToKeystore.Location = new System.Drawing.Point(31, 12);
            this.btmImportSelectedKeysToKeystore.Name = "btmImportSelectedKeysToKeystore";
            this.btmImportSelectedKeysToKeystore.Size = new System.Drawing.Size(223, 23);
            this.btmImportSelectedKeysToKeystore.TabIndex = 13;
            this.btmImportSelectedKeysToKeystore.Text = "Import Selected Keys to Local Key Store";
            this.btmImportSelectedKeysToKeystore.UseVisualStyleBackColor = true;
            this.btmImportSelectedKeysToKeystore.Click += new System.EventHandler(this.btmImportSelectedKeysToKeystore_Click);
            // 
            // keySearchViewBindingSource
            // 
            this.keySearchViewBindingSource.DataSource = typeof(LynxPrivacyLib.KeySearchView);
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
            // keyLineDataGridViewTextBoxColumn
            // 
            this.keyLineDataGridViewTextBoxColumn.DataPropertyName = "keyLine";
            this.keyLineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.keyLineDataGridViewTextBoxColumn.Name = "keyLineDataGridViewTextBoxColumn";
            this.keyLineDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyLineDataGridViewTextBoxColumn.Width = 50;
            // 
            // keyIdDataGridViewTextBoxColumn
            // 
            this.keyIdDataGridViewTextBoxColumn.DataPropertyName = "keyId";
            this.keyIdDataGridViewTextBoxColumn.HeaderText = "Fingerprint";
            this.keyIdDataGridViewTextBoxColumn.Name = "keyIdDataGridViewTextBoxColumn";
            this.keyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // uidStringDataGridViewTextBoxColumn
            // 
            this.uidStringDataGridViewTextBoxColumn.DataPropertyName = "uidString";
            this.uidStringDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.uidStringDataGridViewTextBoxColumn.Name = "uidStringDataGridViewTextBoxColumn";
            this.uidStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.uidStringDataGridViewTextBoxColumn.Width = 300;
            // 
            // keyCreatedDateDataGridViewTextBoxColumn
            // 
            this.keyCreatedDateDataGridViewTextBoxColumn.DataPropertyName = "keyCreatedDate";
            this.keyCreatedDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.keyCreatedDateDataGridViewTextBoxColumn.Name = "keyCreatedDateDataGridViewTextBoxColumn";
            this.keyCreatedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyCreatedDateDataGridViewTextBoxColumn.Width = 60;
            // 
            // keyExpiredDateDataGridViewTextBoxColumn
            // 
            this.keyExpiredDateDataGridViewTextBoxColumn.DataPropertyName = "keyExpiredDate";
            this.keyExpiredDateDataGridViewTextBoxColumn.HeaderText = "ExpiredDate";
            this.keyExpiredDateDataGridViewTextBoxColumn.Name = "keyExpiredDateDataGridViewTextBoxColumn";
            this.keyExpiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyExpiredDateDataGridViewTextBoxColumn.Width = 60;
            // 
            // algorithmDataGridViewTextBoxColumn
            // 
            this.algorithmDataGridViewTextBoxColumn.DataPropertyName = "algorithm";
            this.algorithmDataGridViewTextBoxColumn.HeaderText = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.Name = "algorithmDataGridViewTextBoxColumn";
            this.algorithmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keySizeDataGridViewTextBoxColumn
            // 
            this.keySizeDataGridViewTextBoxColumn.DataPropertyName = "keySize";
            this.keySizeDataGridViewTextBoxColumn.HeaderText = "KeySize";
            this.keySizeDataGridViewTextBoxColumn.Name = "keySizeDataGridViewTextBoxColumn";
            this.keySizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.keySizeDataGridViewTextBoxColumn.Width = 50;
            // 
            // KeyServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 476);
            this.Controls.Add(this.btmImportSelectedKeysToKeystore);
            this.Controls.Add(this.btnLocalSearch);
            this.Controls.Add(this.btnSearchKeyserver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPubKeyFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KeyServer";
            this.Text = "KeyServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyServer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySearchViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource keySearchViewBindingSource;
        private System.Windows.Forms.Button btnSearchKeyserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubKeyFilter;
        private System.Windows.Forms.Button btnLocalSearch;
        private System.Windows.Forms.Button btmImportSelectedKeysToKeystore;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyCreatedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyExpiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algorithmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keySizeDataGridViewTextBoxColumn;
    }
}