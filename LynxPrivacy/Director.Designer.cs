namespace LynxPrivacy
{
    partial class Director
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
            this.btnFormCreateKeypair = new System.Windows.Forms.Button();
            this.chkUseWizards = new System.Windows.Forms.CheckBox();
            this.btnRemoteKeyserver = new System.Windows.Forms.Button();
            this.btnLocalKeystore = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnEncryptClipboard = new System.Windows.Forms.Button();
            this.btnDecryptClipboard = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCreateKeypair
            // 
            this.btnFormCreateKeypair.Location = new System.Drawing.Point(53, 56);
            this.btnFormCreateKeypair.Name = "btnFormCreateKeypair";
            this.btnFormCreateKeypair.Size = new System.Drawing.Size(181, 23);
            this.btnFormCreateKeypair.TabIndex = 0;
            this.btnFormCreateKeypair.Text = "Form to Create PGP Key Pair";
            this.btnFormCreateKeypair.UseVisualStyleBackColor = true;
            this.btnFormCreateKeypair.Click += new System.EventHandler(this.btnFormCreateKeypair_Click);
            // 
            // chkUseWizards
            // 
            this.chkUseWizards.AutoSize = true;
            this.chkUseWizards.Location = new System.Drawing.Point(76, 22);
            this.chkUseWizards.Name = "chkUseWizards";
            this.chkUseWizards.Size = new System.Drawing.Size(182, 17);
            this.chkUseWizards.TabIndex = 1;
            this.chkUseWizards.Text = "Use Wizards for Task completion";
            this.chkUseWizards.UseVisualStyleBackColor = true;
            this.chkUseWizards.CheckedChanged += new System.EventHandler(this.chkUseWizards_CheckedChanged);
            // 
            // btnRemoteKeyserver
            // 
            this.btnRemoteKeyserver.Location = new System.Drawing.Point(53, 85);
            this.btnRemoteKeyserver.Name = "btnRemoteKeyserver";
            this.btnRemoteKeyserver.Size = new System.Drawing.Size(181, 23);
            this.btnRemoteKeyserver.TabIndex = 2;
            this.btnRemoteKeyserver.Text = "Form for Remote Keyserver Access";
            this.btnRemoteKeyserver.UseVisualStyleBackColor = true;
            // 
            // btnLocalKeystore
            // 
            this.btnLocalKeystore.Location = new System.Drawing.Point(53, 114);
            this.btnLocalKeystore.Name = "btnLocalKeystore";
            this.btnLocalKeystore.Size = new System.Drawing.Size(181, 23);
            this.btnLocalKeystore.TabIndex = 3;
            this.btnLocalKeystore.Text = "Form for Local Keystore Access";
            this.btnLocalKeystore.UseVisualStyleBackColor = true;
            this.btnLocalKeystore.Click += new System.EventHandler(this.btnLocalKeystore_Click);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(53, 143);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(181, 23);
            this.btnEncryptFile.TabIndex = 4;
            this.btnEncryptFile.Text = "Form to Encrypt File";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(53, 172);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(181, 23);
            this.btnDecryptFile.TabIndex = 5;
            this.btnDecryptFile.Text = "Form to Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            // 
            // btnEncryptClipboard
            // 
            this.btnEncryptClipboard.Location = new System.Drawing.Point(53, 201);
            this.btnEncryptClipboard.Name = "btnEncryptClipboard";
            this.btnEncryptClipboard.Size = new System.Drawing.Size(181, 23);
            this.btnEncryptClipboard.TabIndex = 6;
            this.btnEncryptClipboard.Text = "Form to Encrypt Clipboard";
            this.btnEncryptClipboard.UseVisualStyleBackColor = true;
            // 
            // btnDecryptClipboard
            // 
            this.btnDecryptClipboard.Location = new System.Drawing.Point(53, 230);
            this.btnDecryptClipboard.Name = "btnDecryptClipboard";
            this.btnDecryptClipboard.Size = new System.Drawing.Size(181, 23);
            this.btnDecryptClipboard.TabIndex = 7;
            this.btnDecryptClipboard.Text = "Form to Decrypt Clipboard";
            this.btnDecryptClipboard.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(274, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Lynx Privacy Overview";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Director
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(617, 352);
            this.ControlBox = false;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnDecryptClipboard);
            this.Controls.Add(this.btnEncryptClipboard);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.btnLocalKeystore);
            this.Controls.Add(this.btnRemoteKeyserver);
            this.Controls.Add(this.chkUseWizards);
            this.Controls.Add(this.btnFormCreateKeypair);
            this.Name = "Director";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormCreateKeypair;
        private System.Windows.Forms.CheckBox chkUseWizards;
        private System.Windows.Forms.Button btnRemoteKeyserver;
        private System.Windows.Forms.Button btnLocalKeystore;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnEncryptClipboard;
        private System.Windows.Forms.Button btnDecryptClipboard;
        private System.Windows.Forms.Button button7;
    }
}