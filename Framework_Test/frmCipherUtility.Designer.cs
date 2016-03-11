﻿namespace BOG.Framework_Test
{
    partial class frmCipherUtility
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
            if (disposing && (components != null))
            {
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
            this.lblEncryptionMethod = new System.Windows.Forms.Label();
            this.cbxEncryptionMethod = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRndPassword = new System.Windows.Forms.Button();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.btnRndSalt = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSwitchSourceAndResult = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnAutoToDecrypted = new System.Windows.Forms.Button();
            this.btnAutoToEncrypted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEncryptionMethod
            // 
            this.lblEncryptionMethod.AutoSize = true;
            this.lblEncryptionMethod.Location = new System.Drawing.Point(13, 13);
            this.lblEncryptionMethod.Name = "lblEncryptionMethod";
            this.lblEncryptionMethod.Size = new System.Drawing.Size(99, 13);
            this.lblEncryptionMethod.TabIndex = 0;
            this.lblEncryptionMethod.Text = "Encryption Method:";
            // 
            // cbxEncryptionMethod
            // 
            this.cbxEncryptionMethod.FormattingEnabled = true;
            this.cbxEncryptionMethod.Location = new System.Drawing.Point(118, 10);
            this.cbxEncryptionMethod.Name = "cbxEncryptionMethod";
            this.cbxEncryptionMethod.Size = new System.Drawing.Size(485, 21);
            this.cbxEncryptionMethod.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 40);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password (key):";
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(84, 66);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(28, 13);
            this.lblSalt.TabIndex = 3;
            this.lblSalt.Text = "Salt:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 95);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(41, 13);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "Source";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 37);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(404, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnRndPassword
            // 
            this.btnRndPassword.Location = new System.Drawing.Point(528, 35);
            this.btnRndPassword.Name = "btnRndPassword";
            this.btnRndPassword.Size = new System.Drawing.Size(75, 23);
            this.btnRndPassword.TabIndex = 6;
            this.btnRndPassword.Text = "Generate";
            this.btnRndPassword.UseVisualStyleBackColor = true;
            this.btnRndPassword.Click += new System.EventHandler(this.btnRndPassword_Click);
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(118, 63);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(404, 20);
            this.txtSalt.TabIndex = 7;
            // 
            // btnRndSalt
            // 
            this.btnRndSalt.Location = new System.Drawing.Point(528, 61);
            this.btnRndSalt.Name = "btnRndSalt";
            this.btnRndSalt.Size = new System.Drawing.Size(75, 23);
            this.btnRndSalt.TabIndex = 8;
            this.btnRndSalt.Text = "Generate";
            this.btnRndSalt.UseVisualStyleBackColor = true;
            this.btnRndSalt.Click += new System.EventHandler(this.btnRndSalt_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(59, 89);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(544, 106);
            this.txtSource.TabIndex = 9;
            this.txtSource.Text = "The quick brown fox jumped over the lazy dog\'s back.\r\n\r\n";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(59, 230);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(544, 108);
            this.txtResult.TabIndex = 11;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 236);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            // 
            // btnSwitchSourceAndResult
            // 
            this.btnSwitchSourceAndResult.Location = new System.Drawing.Point(59, 201);
            this.btnSwitchSourceAndResult.Name = "btnSwitchSourceAndResult";
            this.btnSwitchSourceAndResult.Size = new System.Drawing.Size(90, 23);
            this.btnSwitchSourceAndResult.TabIndex = 12;
            this.btnSwitchSourceAndResult.Text = "Switch";
            this.btnSwitchSourceAndResult.UseVisualStyleBackColor = true;
            this.btnSwitchSourceAndResult.Click += new System.EventHandler(this.btnSwitchSourceAndResult_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(155, 201);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(90, 23);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(251, 201);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(90, 23);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnAutoToDecrypted
            // 
            this.btnAutoToDecrypted.Location = new System.Drawing.Point(347, 201);
            this.btnAutoToDecrypted.Name = "btnAutoToDecrypted";
            this.btnAutoToDecrypted.Size = new System.Drawing.Size(123, 23);
            this.btnAutoToDecrypted.TabIndex = 15;
            this.btnAutoToDecrypted.Text = "Auto To Decrypted";
            this.btnAutoToDecrypted.UseVisualStyleBackColor = true;
            this.btnAutoToDecrypted.Click += new System.EventHandler(this.btnAutoToDecrypted_Click);
            // 
            // btnAutoToEncrypted
            // 
            this.btnAutoToEncrypted.Location = new System.Drawing.Point(476, 201);
            this.btnAutoToEncrypted.Name = "btnAutoToEncrypted";
            this.btnAutoToEncrypted.Size = new System.Drawing.Size(123, 23);
            this.btnAutoToEncrypted.TabIndex = 16;
            this.btnAutoToEncrypted.Text = "Auto To Encrypted";
            this.btnAutoToEncrypted.UseVisualStyleBackColor = true;
            this.btnAutoToEncrypted.Click += new System.EventHandler(this.btnAutoToEncrypted_Click);
            // 
            // frmCipherUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 350);
            this.Controls.Add(this.btnAutoToEncrypted);
            this.Controls.Add(this.btnAutoToDecrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSwitchSourceAndResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnRndSalt);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.btnRndPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbxEncryptionMethod);
            this.Controls.Add(this.lblEncryptionMethod);
            this.Name = "frmCipherUtility";
            this.Text = "CipherUtility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncryptionMethod;
        private System.Windows.Forms.ComboBox cbxEncryptionMethod;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRndPassword;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Button btnRndSalt;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSwitchSourceAndResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnAutoToDecrypted;
        private System.Windows.Forms.Button btnAutoToEncrypted;
    }
}