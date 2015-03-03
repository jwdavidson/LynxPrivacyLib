namespace LynxPrivacy.LocalKeyStoreDialogs
{
    partial class ChangePassphrase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassphrase));
            this.txtNewPassphrase1 = new System.Windows.Forms.TextBox();
            this.txtNewPassphrase2 = new System.Windows.Forms.TextBox();
            this.pnlPP2 = new System.Windows.Forms.Panel();
            this.pnlPP1 = new System.Windows.Forms.Panel();
            this.pnlQuality = new System.Windows.Forms.Panel();
            this.lblNewPassphrase2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblNewPassPhrase1 = new System.Windows.Forms.Label();
            this.txtOrigPassphrase = new System.Windows.Forms.TextBox();
            this.pnlPP0 = new System.Windows.Forms.Panel();
            this.lblOrigPassphrase = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassphrase = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFingerprint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNewPassphrase1
            // 
            this.txtNewPassphrase1.Location = new System.Drawing.Point(155, 146);
            this.txtNewPassphrase1.Name = "txtNewPassphrase1";
            this.txtNewPassphrase1.PasswordChar = '•';
            this.txtNewPassphrase1.Size = new System.Drawing.Size(176, 20);
            this.txtNewPassphrase1.TabIndex = 30;
            this.txtNewPassphrase1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassphrase1_KeyPress);
            this.txtNewPassphrase1.Leave += new System.EventHandler(this.txtNewPassphrase1_Leave);
            // 
            // txtNewPassphrase2
            // 
            this.txtNewPassphrase2.Location = new System.Drawing.Point(155, 179);
            this.txtNewPassphrase2.Name = "txtNewPassphrase2";
            this.txtNewPassphrase2.PasswordChar = '•';
            this.txtNewPassphrase2.Size = new System.Drawing.Size(176, 20);
            this.txtNewPassphrase2.TabIndex = 31;
            this.txtNewPassphrase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassphrase2_KeyPress);
            this.txtNewPassphrase2.Leave += new System.EventHandler(this.txtNewPassphrase2_Leave);
            // 
            // pnlPP2
            // 
            this.pnlPP2.BackColor = System.Drawing.Color.Red;
            this.pnlPP2.Location = new System.Drawing.Point(154, 177);
            this.pnlPP2.Name = "pnlPP2";
            this.pnlPP2.Size = new System.Drawing.Size(178, 25);
            this.pnlPP2.TabIndex = 36;
            // 
            // pnlPP1
            // 
            this.pnlPP1.BackColor = System.Drawing.Color.Red;
            this.pnlPP1.Location = new System.Drawing.Point(154, 144);
            this.pnlPP1.Name = "pnlPP1";
            this.pnlPP1.Size = new System.Drawing.Size(178, 25);
            this.pnlPP1.TabIndex = 37;
            // 
            // pnlQuality
            // 
            this.pnlQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlQuality.Location = new System.Drawing.Point(360, 180);
            this.pnlQuality.Name = "pnlQuality";
            this.pnlQuality.Size = new System.Drawing.Size(142, 18);
            this.pnlQuality.TabIndex = 35;
            // 
            // lblNewPassphrase2
            // 
            this.lblNewPassphrase2.AutoSize = true;
            this.lblNewPassphrase2.Location = new System.Drawing.Point(33, 185);
            this.lblNewPassphrase2.Name = "lblNewPassphrase2";
            this.lblNewPassphrase2.Size = new System.Drawing.Size(116, 13);
            this.lblNewPassphrase2.TabIndex = 34;
            this.lblNewPassphrase2.Text = "Verify New Passphrase";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(358, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Unhide Passphrase Input";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblNewPassPhrase1
            // 
            this.lblNewPassPhrase1.AutoSize = true;
            this.lblNewPassPhrase1.Location = new System.Drawing.Point(33, 152);
            this.lblNewPassPhrase1.Name = "lblNewPassPhrase1";
            this.lblNewPassPhrase1.Size = new System.Drawing.Size(87, 13);
            this.lblNewPassPhrase1.TabIndex = 32;
            this.lblNewPassPhrase1.Text = "New Passphrase";
            // 
            // txtOrigPassphrase
            // 
            this.txtOrigPassphrase.Location = new System.Drawing.Point(155, 110);
            this.txtOrigPassphrase.Name = "txtOrigPassphrase";
            this.txtOrigPassphrase.PasswordChar = '•';
            this.txtOrigPassphrase.Size = new System.Drawing.Size(176, 20);
            this.txtOrigPassphrase.TabIndex = 38;
            this.txtOrigPassphrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrigPassphrase_KeyPress);
            this.txtOrigPassphrase.Leave += new System.EventHandler(this.txtOrigPassphrase_Leave);
            // 
            // pnlPP0
            // 
            this.pnlPP0.BackColor = System.Drawing.Color.Red;
            this.pnlPP0.Location = new System.Drawing.Point(154, 108);
            this.pnlPP0.Name = "pnlPP0";
            this.pnlPP0.Size = new System.Drawing.Size(178, 25);
            this.pnlPP0.TabIndex = 40;
            // 
            // lblOrigPassphrase
            // 
            this.lblOrigPassphrase.AutoSize = true;
            this.lblOrigPassphrase.Location = new System.Drawing.Point(33, 116);
            this.lblOrigPassphrase.Name = "lblOrigPassphrase";
            this.lblOrigPassphrase.Size = new System.Drawing.Size(100, 13);
            this.lblOrigPassphrase.TabIndex = 39;
            this.lblOrigPassphrase.Text = "Original Passphrase";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(546, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 24);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePassphrase
            // 
            this.btnChangePassphrase.Location = new System.Drawing.Point(412, 217);
            this.btnChangePassphrase.Name = "btnChangePassphrase";
            this.btnChangePassphrase.Size = new System.Drawing.Size(113, 24);
            this.btnChangePassphrase.TabIndex = 42;
            this.btnChangePassphrase.Text = "Change Passphrase";
            this.btnChangePassphrase.UseVisualStyleBackColor = true;
            this.btnChangePassphrase.Click += new System.EventHandler(this.btnChangePassphrase_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(54, 217);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 43;
            this.lblResult.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "EMail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fingerprint";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 22);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(327, 20);
            this.txtName.TabIndex = 47;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(327, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // txtFingerprint
            // 
            this.txtFingerprint.Location = new System.Drawing.Point(126, 72);
            this.txtFingerprint.Name = "txtFingerprint";
            this.txtFingerprint.ReadOnly = true;
            this.txtFingerprint.Size = new System.Drawing.Size(327, 20);
            this.txtFingerprint.TabIndex = 49;
            // 
            // ChangePassphrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 259);
            this.Controls.Add(this.txtFingerprint);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnChangePassphrase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtOrigPassphrase);
            this.Controls.Add(this.pnlPP0);
            this.Controls.Add(this.lblOrigPassphrase);
            this.Controls.Add(this.txtNewPassphrase1);
            this.Controls.Add(this.txtNewPassphrase2);
            this.Controls.Add(this.pnlPP2);
            this.Controls.Add(this.pnlPP1);
            this.Controls.Add(this.pnlQuality);
            this.Controls.Add(this.lblNewPassphrase2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblNewPassPhrase1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassphrase";
            this.Text = "ChangePassphrase";
            this.Load += new System.EventHandler(this.ChangePassphrase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPassphrase1;
        private System.Windows.Forms.TextBox txtNewPassphrase2;
        private System.Windows.Forms.Panel pnlPP2;
        private System.Windows.Forms.Panel pnlPP1;
        private System.Windows.Forms.Panel pnlQuality;
        private System.Windows.Forms.Label lblNewPassphrase2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblNewPassPhrase1;
        private System.Windows.Forms.TextBox txtOrigPassphrase;
        private System.Windows.Forms.Panel pnlPP0;
        private System.Windows.Forms.Label lblOrigPassphrase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePassphrase;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFingerprint;
    }
}