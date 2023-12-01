namespace CriptoFile
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.buttonDecryptFile = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave não definida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(254, 166);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(293, 31);
            this.txtKey.TabIndex = 1;
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncryptFile.Location = new System.Drawing.Point(16, 217);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(255, 85);
            this.buttonEncryptFile.TabIndex = 2;
            this.buttonEncryptFile.Text = "Criptografar arquivo";
            this.buttonEncryptFile.UseVisualStyleBackColor = false;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonDecryptFile
            // 
            this.buttonDecryptFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecryptFile.Location = new System.Drawing.Point(277, 217);
            this.buttonDecryptFile.Name = "buttonDecryptFile";
            this.buttonDecryptFile.Size = new System.Drawing.Size(255, 85);
            this.buttonDecryptFile.TabIndex = 3;
            this.buttonDecryptFile.Text = "Descriptografar arquivo";
            this.buttonDecryptFile.UseVisualStyleBackColor = false;
            this.buttonDecryptFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateAsmKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(538, 217);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(255, 85);
            this.buttonCreateAsmKeys.TabIndex = 4;
            this.buttonCreateAsmKeys.Text = "Criar chaves";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = false;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportPublicKey.Location = new System.Drawing.Point(16, 308);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(255, 85);
            this.buttonExportPublicKey.TabIndex = 5;
            this.buttonExportPublicKey.Text = "Exportar chave pública";
            this.buttonExportPublicKey.UseVisualStyleBackColor = false;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonImportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportPublicKey.Location = new System.Drawing.Point(277, 308);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(255, 85);
            this.buttonImportPublicKey.TabIndex = 6;
            this.buttonImportPublicKey.Text = "Importar chave pública";
            this.buttonImportPublicKey.UseVisualStyleBackColor = false;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGetPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(538, 308);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(255, 85);
            this.buttonGetPrivateKey.TabIndex = 7;
            this.buttonGetPrivateKey.Text = "Obter chave privada";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = false;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 403);
            this.Controls.Add(this.buttonGetPrivateKey);
            this.Controls.Add(this.buttonImportPublicKey);
            this.Controls.Add(this.buttonExportPublicKey);
            this.Controls.Add(this.buttonCreateAsmKeys);
            this.Controls.Add(this.buttonDecryptFile);
            this.Controls.Add(this.buttonEncryptFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button buttonEncryptFile;
        private System.Windows.Forms.Button buttonDecryptFile;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonExportPublicKey;
        private System.Windows.Forms.Button buttonImportPublicKey;
        private System.Windows.Forms.Button buttonGetPrivateKey;
    }
}

