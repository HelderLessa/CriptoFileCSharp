using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace CriptoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Criptografia.cspp = new CspParameters();
            Criptografia.EncrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Encrypt\";
            Criptografia.DecrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Decrypt\";
            Criptografia.SrcFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            if(Criptografia.rsa == null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave não definida.";
            }
            else
            {
                // Mostra uma caixa de diálogo para escolher um arquivo para criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.SrcFolder;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName; // arquivo selecionado através do dialog
                    FileInfo fInfo = new FileInfo(fName);
                    // Passa o nome do arquivo com o caminho
                    string name = fInfo.FullName;
                    label1.Text = Criptografia.EncryptFile(name); // criptografa o arquivo
                }
            }
        }

        private void buttonDecryptFile_Click(object sender, EventArgs e)
        {
            if (Criptografia.rsa == null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave não definida.";
            }
            else
            {
                // Mostra uma caixa de diálogo para escolher um arquivo para criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.EncrFolder;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName; // arquivo selecionado através do dialog
                    FileInfo fInfo = new FileInfo(fName);
                    // Passa o nome do arquivo
                    string name = fInfo.Name;
                    label1.Text = Criptografia.DecryptFile(name); // Descriptografa o arquivo
                }
            }
        }

        private void buttonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtKey.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Insira um valor para definir a chave pública.";
                txtKey.Focus();
                return;
            }

            Criptografia.keyName = txtKey.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.CreateAsmKeys();
        }

        private void buttonExportPublicKey_Click(object sender, EventArgs e)
        {
            if(Criptografia.ExportPublicKey())
            {
                label1.ForeColor = Color.DarkBlue;
                label1.Text = "Chave pública exportada";
            }
        }

        private void buttonImportPublicKey_Click(object sender, EventArgs e)
        {
            Criptografia.keyName = "Pública";
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.ImportPublicKey();           
        }

        private void buttonGetPrivateKey_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtKey.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Insira um valor para definir a chave privada.";
                txtKey.Focus();
                return;
            }

            Criptografia.keyName = txtKey.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.GetPrivateKey();
        }
    }
}
